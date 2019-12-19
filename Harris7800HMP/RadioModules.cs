using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class RadioModules
    {
        public enum ModuleType
        {
            Handset, Usb, Coupler
        }
        public class Location
        {
            public int x = 0;
            public int y = 0;

            public Location(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
        }

        public Dictionary< ModuleType, Tuple<Bitmap, Location>> modulesImage = new Dictionary<ModuleType, Tuple<Bitmap, Location>> {
            { ModuleType.Handset, new Tuple<Bitmap, Location>(Properties.Resources.handsetTube, new Location(680, 360)) },
            { ModuleType.Usb , new Tuple<Bitmap, Location>(Properties.Resources.usbJustConnector, new Location(700, 284)) },
            { ModuleType.Coupler , new Tuple<Bitmap, Location>(Properties.Resources.coupler, new Location(0, 180)) }
        };
    }
}
