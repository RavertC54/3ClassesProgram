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
            //Creating a new Car object
            Car car0 = new Car();
            car0.Type = "Sedan";
            car0.Make = "Ford";
            car0.Automatic = false;
            car0.RequiredDays = 3;

            //Creating a new Mechanic object;
            Mechanic mechanic0 = new Mechanic();
            mechanic0.Name = "Jim Thomas";
            mechanic0.Specialty = true;
            mechanic0.Experience = 3;

            //Creating a new Tool object
            Tool tool0 = new Tool();
            tool0.Type = "Jack";
            tool0.Solo = true;
            tool0.Certification = false;

            Console.ReadLine();
        }
    }
}
