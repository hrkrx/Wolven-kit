﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using WolvenKit.Common;

namespace WolvenKit.Controllers
{
    class MockGameController : GameControllerBase
    {
        public override List<IGameArchiveManager> GetArchiveManagersManagers()
        {
            return new List<IGameArchiveManager>();
        }

        public override List<string> GetAvaliableClasses()
        {
            return new List<string>();
        }

        public override void HandleStartup()
        {
            //Nothing to do here :)
        }

        public override Task<bool> PackAndInstallProject()
        {
            //Nothing to do here :)
            return new Task<bool>(new Func<bool>(() => true));
        }

        public override Task<bool> PackageMod()
        {
            //Nothing to do here :)
            return Task.FromResult(true);
        }
    }
}
