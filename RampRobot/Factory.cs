using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampRobot
{
    class Factory
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int AantalRobots { get; set; }
        public int xRand { get; set; }
        public int yRand { get; set; }
        public int Beurten { get; set; }
        public int BeweegtRobot { get; set; }
        public List<Robot> AlleRobots = new List<Robot>();
        public Mechanic Mac;
        Random rnd = new Random();

        public void Run()
        {
            TekenFabriek();
            string StapMechanic = Console.ReadLine();
            Mac.StapMech(StapMechanic, Width, Height);
            foreach (Robot Rob in AlleRobots)
            {
                int Rstap = rnd.Next(0, 3);
                Rob.StapRob(Width, Height, Rstap);
            }
            TekenFabriek();

        }


        public Factory(int Width, int Height, int AantalRobots)
        {
            this.Width = Width;
            this.Height = Height;
            this.AantalRobots = AantalRobots;
            Mac = new Mechanic(0, 0);
            PlaatsRobots();
        }

        public bool IsRobot(int xRobot, int yRobot, List<Robot> AlleRobots)
        {
            foreach (Robot robbie in AlleRobots)
            {
                if (xRobot == robbie.xRobot && yRobot == robbie.yRobot)
                    return true;
                else if (xRobot == 0 && yRobot == 0)
                    return true;

            }
            return false;
        }


        public void TekenFabriek()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i == Mac.xpos && j == Mac.ypos)
                    {
                        Console.Write("M");
                    }
                    else
                    {
                        Robot robot = CheckCellForRobot(i, j); // check op robot
                        if(robot == null) 
                            Console.Write(".");
                        else
                            Console.Write("R");
                    }
                }
                Console.WriteLine();
            }
            
        }

        public Robot CheckCellForRobot(int x, int y)
        {
            foreach (Robot robot in AlleRobots)
            {
                if (x == robot.xRobot && y == robot.yRobot)
                {
                    return robot;
                }
            }
            return null;
        }

        public void PlaatsRobots()
        {
            while (AlleRobots.Count < AantalRobots)
            {
                int xRobot = rnd.Next(0, Width - 1);
                int yRobot = rnd.Next(0, Height - 1);
                if (!IsRobot(xRobot, yRobot, AlleRobots))
                {
                    Robot rob = new Robot(xRobot, yRobot);
                    AlleRobots.Add(rob);
                }
            }
        }
    }
}
