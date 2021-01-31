﻿using System.CommandLine;
using System.CommandLine.Invocation;
using WolvenKit.Common.DDS;

namespace CP77Tools.Commands
{
    public class ExportCommand : Command
    {
        private new const string Name = "export";
        private new const string Description = "Export a file or a list of files into raw files.";
        
        public ExportCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path. Must be a file or a list of files."));
            AddOption(new Option<EUncookExtension>(new[] { "--uext" }, "Uncook extension (tga, bmp, jpg, png, dds). Default is tga."));

            Handler = CommandHandler.Create<string[], EUncookExtension>(Tasks.ConsoleFunctions.ExportTask);
        }
    }
}