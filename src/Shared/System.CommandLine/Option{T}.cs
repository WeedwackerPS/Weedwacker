﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.CommandLine.Binding;
using System.CommandLine.Completions;
using System.CommandLine.Parsing;

namespace System.CommandLine
{
    /// <inheritdoc cref="Option" />
    /// <typeparam name="T">The <see cref="System.Type"/> that the option's arguments are expected to be parsed as.</typeparam>
    public class Option<T> : Option, IValueDescriptor<T>
    {
        private readonly Argument<T> _argument;

        /// <inheritdoc/>
        public Option(
            string name,
            string? description = null) 
            : this(name, description, new Argument<T>())
        { }

        /// <inheritdoc/>
        public Option(
            string[] aliases,
            string? description = null) 
            : this(aliases, description, new Argument<T>())
        { }

        /// <inheritdoc/>
        public Option(
            string name,
            Func<ArgumentResult, T> parseArgument,
            bool isDefault = false,
            string? description = null) 
            : this(name, description, 
                  new Argument<T>(parseArgument ?? throw new ArgumentNullException(nameof(parseArgument)), isDefault))
        { }

        /// <inheritdoc/>
        public Option(
            string[] aliases,
            Func<ArgumentResult, T> parseArgument,
            bool isDefault = false,
            string? description = null) 
            : this(aliases, description, new Argument<T>(parseArgument ?? throw new ArgumentNullException(nameof(parseArgument)), isDefault))
        { }

        /// <inheritdoc/>
        public Option(
            string name,
            Func<T> getDefaultValue,
            string? description = null) 
            : this(name, description, 
                  new Argument<T>(getDefaultValue ?? throw new ArgumentNullException(nameof(getDefaultValue))))
        { }

        /// <inheritdoc/>
        public Option(
            string[] aliases,
            Func<T> getDefaultValue,
            string? description = null)
            : this(aliases, description, new Argument<T>(getDefaultValue ?? throw new ArgumentNullException(nameof(getDefaultValue))))
        {
        }

        private protected Option(
            string name,
            string? description,
            Argument<T> argument)
            : base(name, description)
        {
            argument.AddParent(this);
            _argument = argument;
        }

        private protected Option(
            string[] aliases,
            string? description,
            Argument<T> argument)
            : base(aliases, description)
        {
            argument.AddParent(this);
            _argument = argument;
        }

        internal sealed override Argument Argument => _argument;

        /// <summary>
        /// Sets the default value for the option.
        /// </summary>
        /// <param name="value">The default value for the option.</param>
        public void SetDefaultValue(T value) => _argument.SetDefaultValue(value);

        /// <summary>
        /// Sets a delegate to invoke when the default value for the option is required.
        /// </summary>
        /// <param name="getDefaultValue">The delegate to invoke to return the default value.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="getDefaultValue"/> is null.</exception>
        public void SetDefaultValueFactory(Func<T> getDefaultValue) =>
            _argument.SetDefaultValueFactory(getDefaultValue);

        /// <summary>
        /// Configures the option to accept only the specified values, and to suggest them as command line completions.
        /// </summary>
        /// <param name="values">The values that are allowed for the option.</param>
        /// <returns>The configured option.</returns>
        public Option<T> AcceptOnlyFromAmong(params string[] values)
        {
            _argument.AcceptOnlyFromAmong(values);

            return this;
        }

        /// <summary>
        /// Adds completions for the option.
        /// </summary>
        /// <param name="completions">The completions to add.</param>
        /// <returns>The configured option.</returns>
        public Option<T> AddCompletions(params string[] completions)
        {
            _argument.Completions.Add(completions);
            return this;
        }

        /// <summary>
        /// Adds completions for the option.
        /// </summary>
        /// <param name="completionsDelegate">A function that will be called to provide completions.</param>
        /// <returns>The configured option.</returns>
        public Option<T> AddCompletions(Func<CompletionContext, IEnumerable<string>> completionsDelegate)
        {
            _argument.Completions.Add(completionsDelegate);
            return this;
        }

        /// <summary>
        /// Adds completions for the option.
        /// </summary>
        /// <param name="completionsDelegate">A function that will be called to provide completions.</param>
        /// <returns>The configured option.</returns>
        public Option<T> AddCompletions(Func<CompletionContext, IEnumerable<CompletionItem>> completionsDelegate)
        {
            _argument.Completions.Add(completionsDelegate);
            return this;
        }

        /// <summary>
        /// Adds a validator that will be called when the option is matched by the parser.
        /// </summary>
        /// <param name="validate">An action used to validate the <see cref="OptionResult"/> produced during parsing.</param>
        public Option<T> AddValidator(Action<OptionResult> validate)
        {
            Validators.Add(validate);
            return this;
        }

        /// <summary>
        /// Configures the option to accept only values representing legal file paths.
        /// </summary>
        /// <returns>The configured option.</returns>
        public Option<T> AcceptLegalFilePathsOnly()
        {
            _argument.AcceptLegalFilePathsOnly();
            return this;
        }

        /// <summary>
        /// Configures the option to accept only values representing legal file names.
        /// </summary>
        /// <remarks>A parse error will result, for example, if file path separators are found in the parsed value.</remarks>
        /// <returns>The configured option.</returns>
        public Option<T> AcceptLegalFileNamesOnly()
        {
            _argument.AcceptLegalFileNamesOnly();
            return this;
        }
    }
}