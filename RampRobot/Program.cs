using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fabriekje = new Factory(5, 5, 4, 1000);
            fabriekje.Run();

            Console.ReadLine();
        }
    }
}
