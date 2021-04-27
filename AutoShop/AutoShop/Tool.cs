using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Tool
    {
        private string _type;
        private bool _solo;
        private bool _certification;

        public string Type { get => _type; set => _type = value; }
        public bool Solo { get => _solo; set => _solo = value; }
        public bool Certification { get => _certification; set => _certification = value; }

        public Tool()
        {
            Console.WriteLine("A new tool has been added to the garage.");
        }
    }
}
