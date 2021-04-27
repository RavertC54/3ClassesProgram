using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Car
    {
        private string _type;
        private string _make;
        private bool _automatic;
        private int _requiredDays;

        public string Type { get => _type; set => _type = value; }
        public string Make { get => _make; set => _make = value; }
        public bool Automatic { get => _automatic; set => _automatic = value; }
        public int RequiredDays { get => _requiredDays; set => _requiredDays = value; }

        public Car()
        {
            Console.WriteLine("A new car has been added to the books");
        }
    }
}
