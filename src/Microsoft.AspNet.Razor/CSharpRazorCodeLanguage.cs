// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Chunks.Generators;
using Microsoft.AspNet.Razor.CodeGenerators;
using Microsoft.AspNet.Razor.Parser;
#if NET45

#endif

namespace Microsoft.AspNet.Razor
{
    /// <summary>
    /// Defines the C# Code Language for Razor
    /// </summary>
    public class CSharpRazorCodeLanguage : RazorCodeLanguage
    {
        private const string CSharpLanguageName = "csharp";

        /// <summary>
        /// Returns the name of the language: "csharp"
        /// </summary>
        public override string LanguageName
        {
            get { return CSharpLanguageName; }
        }

        /// <summary>
        /// Constructs a new instance of the code parser for this language
        /// </summary>
        public override ParserBase CreateCodeParser()
        {
            return new CSharpCodeParser();
        }

        /// <summary>
        /// Constructs a new instance of the chunk generator for this language with the specified settings
        /// </summary>
        public override RazorChunkGenerator CreateChunkGenerator(
            string className,
            string rootNamespaceName,
            string sourceFileName,
            RazorEngineHost host)
        {
            return new RazorChunkGenerator(className, rootNamespaceName, sourceFileName, host);
        }

        public override CodeGenerator CreateCodeGenerator(CodeGeneratorContext context)
        {
            return new CSharpCodeGenerator(context);
        }
    }
}
