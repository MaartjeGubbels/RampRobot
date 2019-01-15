using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampRobot
{
    class Robot
    {
        public int xRobot { get; set; }
        public int yRobot { get; set; }
        Random rnd = new Random();


        public Robot(int xRobot, int yRobot)
        {
            this.xRobot = xRobot;
            this.yRobot = yRobot;
        }

        public void StapRob(int width, int height, int Rstap)
        {
            if (Rstap == 0)
            {
                if (xRobot != 0)
                {
                    xRobot--;
                }
            }

            else if (Rstap == 1)
            {
                if (yRobot != 0)
                {
                    yRobot--;
                }
            }

            else if (Rstap == 2)
            {
                if (xRobot != height - 1)
                {
                    xRobot++;
                }
            }

            else if (Rstap == 3)
            {
                if (yRobot != width - 1)
                {
                    yRobot++;
                }
            }
        }
    }

}
