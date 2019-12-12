using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class WidgetQueue
    {
        List<Widget> queue = new List<Widget>();
        int currentIndex = -1;

        public void add(Widget wdg)
        {
            queue.Add(wdg);
        }
        public Widget next()
        {
            currentIndex++;

            if(currentIndex > queue.Count - 1)
            {
                return null;
            }

            return queue[currentIndex];
        }

        public Widget current()
        {
            if (currentIndex > queue.Count - 1)
            {
                return null;
            }

            return queue[currentIndex];
        }

        public void clear()
        {
            queue.Clear();
            currentIndex = -1;
        }
    }
}
