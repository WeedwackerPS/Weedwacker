// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace System.CommandLine.Invocation
{
    internal class AnonymousCommandHandler : ICommandHandler
    {
        private readonly Func<InvocationContext, Task>? _asyncHandle;
        private readonly Action<InvocationContext>? _syncHandle;

        private UserRank requiredUserRank;

        public AnonymousCommandHandler(Func<InvocationContext,Task> handle, UserRank requiredUserRank)
        {
            _asyncHandle = handle ?? throw new ArgumentNullException(nameof(handle));
            this.requiredUserRank = requiredUserRank;
        }


        public AnonymousCommandHandler(Action<InvocationContext> handle, UserRank requiredUserRank)
        {
            _syncHandle = handle ?? throw new ArgumentNullException(nameof(handle));
            this.requiredUserRank = requiredUserRank;

        }
        public int Invoke(InvocationContext context,UserRank rank)
        {
            if (_syncHandle is not null)
            {
                _syncHandle(context);
                return context.ExitCode;
            }

            return SyncUsingAsync(context, rank); // kept in a separate method to avoid JITting
        }

        private int SyncUsingAsync(InvocationContext context,UserRank rank) => InvokeAsync(context,rank).GetAwaiter().GetResult();

        public async Task<int> InvokeAsync(InvocationContext context,UserRank rank)
        {
            if (_syncHandle is not null)
            {
                return Invoke(context,rank);
            }

            if (requiredUserRank>rank)
            {
                context.Console.Error.Write("Permission deined!\n");
                return -1;
            }

            object returnValue = _asyncHandle!(context);

            int ret;

            switch (returnValue)
            {
                case Task<int> exitCodeTask:
                    ret = await exitCodeTask;
                    break;
                case Task task:
                    await task;
                    ret = context.ExitCode;
                    break;
                case int exitCode:
                    ret = exitCode;
                    break;
                default:
                    ret = context.ExitCode;
                    break;
            }

            return ret;
        }
    }
}