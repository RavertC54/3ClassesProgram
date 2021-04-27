using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding Cars into the system
            Car car0 = new Car();
            car0.Type = "Sedan";
            car0.Make = "Ford";
            car0.Automatic = false;
            car0.RequiredDays = 3;

            //Adding a Mechanic into the system;
            Mechanic mechanic = new Mechanic();
            mechanic.Name = "Jim Thomas";
            mechanic.Specialty = true;
            mechanic.Experience = 3;




            Console.ReadLine();
        }
    }
}
