using System.Collections.Generic;

namespace Harris7800HMP
{
    public enum SwitcherState
    {
        OFF,
        PT,
        CT,
        LD,
        Z,
        CLR
    };
    public class Switcher
    {
        private SwitcherState state;
        internal SwitcherState State { get => state; set => state = value; }

        private Dictionary<SwitcherState, System.Drawing.Bitmap> imagesPath = new Dictionary<SwitcherState, System.Drawing.Bitmap>()
        {
            { SwitcherState.OFF, Properties.Resources.offSwitch },
            { SwitcherState.PT, Properties.Resources.PTSwitch },
            { SwitcherState.CT, Properties.Resources.CTSwitch },
            { SwitcherState.LD, Properties.Resources.LDSwitch },
            { SwitcherState.Z, Properties.Resources.ZSwitch },
            { SwitcherState.CLR, Properties.Resources.ClrSwitch },
        };

        public SwitcherState NextState()
        {
            if ((int)state + 1 > 5)
            {
                state = SwitcherState.OFF;
            }
            else
            {
                state += 1;
            }
            return state;
        }

        public void InitToOff()
        {
            state = SwitcherState.OFF;
        }

        public System.Drawing.Bitmap GetImage()
        {
            return imagesPath[state];
        }
    }
}
