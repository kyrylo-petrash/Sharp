using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    // 1
    public class MyClass
    {
        public string? Properties { get; set; } // ? тип допускающий значение null
    }

    // 2
    public class InitClass
    {
        public string? Properties { get; init; } // при init требуется запретить повторное присвоение значения свойству
    }

    // 3
    public class DualClass
    {
        public DualClass()
        {
            AutoProperty = SimpleProperty = ExpBodyProperty = "Some value...";
        }

        public string AutoProperty { get; init; } = "Some value";


        string? field = null;

        public string SimpleProperty { get { return field; } init { field = value; } } // init это set

        public string ExpBodyProperty { get => field; init => field = value; }

        // Only Init

        // public string OnlyInitAuto { init; } = "Some value"; // не бывает

        public string OnlyInitSimpleProperty { init { field = value; } }

        public string OnlyInitExpBodyProperty { init => field = value; }
    }
}
