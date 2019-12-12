using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class Display
    {
        List<string> lines = new List<string>();
        Battery battery = new Battery();
        RadioStation radioStation;
        public Display(RadioStation station)
        {
            Lines.Add(" " + battery);
            Lines.Add("111111111111111111111111111");
            Lines.Add("line3");
            Lines.Add("line4🥺");
            radioStation = station;
        }

        public List<string> Lines { get => lines;}

        public override string ToString()
        {
            string result = radioStation.ToString();
            return result;
        }
    }
}
