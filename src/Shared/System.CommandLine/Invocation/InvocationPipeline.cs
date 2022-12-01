﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.CommandLine.Invocation
{
    internal class InvocationPipeline
    {
        private readonly ParseResult _parseResult;

        public InvocationPipeline(ParseResult parseResult)
        {
            _parseResult = parseResult ?? throw new ArgumentNullException(nameof(parseResult));
        }

        public Task<int> InvokeAsync(UserRank rank, IConsole? console = null, CancellationToken cancellationToken = default)
        {
            var context = new InvocationContext(_parseResult, console, cancellationToken);

            if (context.Parser.Configuration.Middleware.Count == 0
                && context.ParseResult.CommandResult.Command.Handler is ICommandHandler handler)
            {
                return handler.InvokeAsync(context,rank);
            }

            return FullInvocationChainAsync(context,rank);

            static async Task<int> FullInvocationChainAsync(InvocationContext context,UserRank rank)
            {
                InvocationMiddleware invocationChain = BuildInvocationChain(context,rank , true);

                await invocationChain(context, _ => Task.CompletedTask);

                return GetExitCode(context);
            }
        }

        public int Invoke(UserRank rank,IConsole? console = null)
        {
            var context = new InvocationContext(_parseResult, console);

            if (context.Parser.Configuration.Middleware.Count == 0
                && context.ParseResult.CommandResult.Command.Handler is ICommandHandler handler)
            {
                return handler.Invoke(context,rank);
            }

            return FullInvocationChain(context,rank ); // kept in a separate method to avoid JITting

            static int FullInvocationChain(InvocationContext context,UserRank rank)
            {
                InvocationMiddleware invocationChain = BuildInvocationChain(context,rank, false);

                invocationChain(context, static _ => Task.CompletedTask).ConfigureAwait(false).GetAwaiter().GetResult();

                return GetExitCode(context);
            }
        }

        private static InvocationMiddleware BuildInvocationChain(InvocationContext context,UserRank rank, bool invokeAsync)
        {
            var invocations = new List<InvocationMiddleware>(context.Parser.Configuration.Middleware.Count + 1);
            invocations.AddRange(context.Parser.Configuration.Middleware);

            invocations.Add(async (invocationContext, _) =>
            {
                if (invocationContext
                    .ParseResult
                    .CommandResult
                    .Command is Command command)
                {
                    var handler = command.Handler;

                    if (handler is not null)
                    {
                        context.ExitCode = invokeAsync
                            ? await handler.InvokeAsync(invocationContext,rank)
                            : handler.Invoke(invocationContext,rank);
                    }
                }
            });

            return invocations.Aggregate(
                (first, second) =>
                    (ctx, next) =>
                        first(ctx,
                            c => second(c, next)));
        }

        private static int GetExitCode(InvocationContext context)
        {
            context.InvocationResult?.Invoke(context);

            return context.ExitCode;
        }
    }
}