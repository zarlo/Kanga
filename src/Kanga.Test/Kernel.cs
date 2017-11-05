using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Kanga.Test
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Kanga.Manager.Init();
        }
        
        protected override void Run()
        {

            Manager.Tick();

        }
    }
}
