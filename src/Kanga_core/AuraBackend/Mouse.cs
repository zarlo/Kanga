using Kanga_core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_Aura.AuraBackend
{
    public class Mouse : IMouse
    {
        public Kanga_core.Mouse GetData()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void OnClick(params object[] data)
        {

            Kanga_core.Mouse mouse = GetData();

        }
    }
}
