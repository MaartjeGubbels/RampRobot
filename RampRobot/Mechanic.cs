using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampRobot
{
    class Mechanic
    {
        public int xpos { get; set; }
        public int ypos { get; set; }

        public Mechanic(int xpos, int ypos)
        {
            this.xpos = xpos;
            this.ypos = ypos;
        }

        public void StapMech(string StapMechanic, int width, int height)
        {
            foreach (char Stap in StapMechanic)
            {
                if (Stap.Equals('w'))
                {
                    if (xpos != 0)
                    {
                        xpos--;
                    }
                }

                else if (Stap.Equals('a'))
                {
                    if (ypos != 0)
                    {
                        ypos--;
                    }
                }

                else if (Stap.Equals('s'))
                {
                    if (xpos != height-1)
                    {
                        xpos++;
                    }
                }

                else if (Stap.Equals('d'))
                {
                    if (ypos != width-1)
                    {
                        ypos++;
                    }
                }
            }
        }
    }
}
