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
            // creer fabriek van grootte 5,5 met 4 robots en 1000 pogingen
            Factory fabriek = new Factory(5, 5, 3, 1000);
            fabriek.Run();

            Console.ReadLine();
        }
    }
}
