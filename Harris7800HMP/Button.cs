using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class Button
    {
        string name;

        public Button(string n, Action<Button, RadioStation, Widget> act)
        {
            Name = n;
            Action = act;
        }

        public string Name { get => name; set => name = value; }
        internal Action<Button, RadioStation, Widget> Action { get; set; }

        public void click(RadioStation station, Widget widget)
        {
            Action?.Invoke(this, station, widget);
        }
    }
}
