using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class MyProperties
    {
        int field = -1;

        public int PropertyFirst
        {
            get => (field < 0) ? default : field; // default  для int = 0
            set { field = value; }
        }

        public int PropertySecond
        {
            get { return (field < 0) ? default : field; } // getter (accessor) доступ
            set => field = value; // setter (mutator) мутировать
        }
    }
}
