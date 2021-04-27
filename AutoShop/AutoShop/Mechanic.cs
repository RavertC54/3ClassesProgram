using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Mechanic
    {
        private string _name;
        private bool _specialty;
        private int _experience;

        public string Name { get => _name; set => _name = value; }
        public bool Specialty { get => _specialty; set => _specialty = value; }
        public int Experience { get => _experience; set => _experience = value; }

        public Mechanic()
        {
            Console.WriteLine("A mechanic has just been hired.");
        }
    }
}
