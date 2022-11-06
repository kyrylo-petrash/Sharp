using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class MyProperties
    {
        public string Name { get; set; }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
