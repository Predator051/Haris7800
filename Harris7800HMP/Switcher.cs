using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public enum SwitcherState
    {
        Off, 
        PT,
        CT,
        LD,
        Z,
        CLR
    };
    public class Switcher
    {
        SwitcherState state;
        internal SwitcherState State { get => state; set => state = value; }

        Dictionary<SwitcherState, System.Drawing.Bitmap> imagesPath = new Dictionary<SwitcherState, System.Drawing.Bitmap>()
        {
            { SwitcherState.Off, Properties.Resources.offSwitch },
            { SwitcherState.PT, Properties.Resources.PTSwitch },
            { SwitcherState.CT, Properties.Resources.CTSwitch },
            { SwitcherState.LD, Properties.Resources.LDSwitch },
            { SwitcherState.Z, Properties.Resources.ZSwitch },
            { SwitcherState.CLR, Properties.Resources.ClrSwitch },
        };

        public SwitcherState nextState()
        {
            if((int)state + 1 > 5)
            {
                state = SwitcherState.Off;
            } else
            {
                state = state + 1;
            }
            return state;
        }

        public void initToOff()
        {
            state = SwitcherState.Off;
        }

        public System.Drawing.Bitmap getImage()
        {
            return imagesPath[state];
        }
    }
}
