using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core
{
    public partial class Kanga
    {

        public static IBackend Backend { private set; get; }
        public static IMouse Mouse { private set; get; }

        public static void Init(IBackend mBackend, IMouse mMouse)
        {

            Mouse = mMouse;
            Backend = mBackend;

            Mouse.Init();
            Backend.Init();
            
        }

        public static void Init()
        {

#if Backend_Windows

            Init( new Kanga_core.WindowsBackend.Backend(), new Kanga_core.WindowsBackend.Mouse());

#endif

#if Backend_Aura

            Init( new Kanga_core.AuraBackend.Backend(), new Kanga_core.AuraBackend.Mouse());

#endif
                                 
        }


        public static void Render()
        {

            Backend.Render();
            
        }


    }
}
