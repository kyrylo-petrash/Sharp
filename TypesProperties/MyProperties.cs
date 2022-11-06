using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class MyProperties
    {
        private int myVarieble;

        // 1. Полное свойство
        public int MyProperty { get { return myVarieble; } set { myVarieble = value; } }

        // 2. Полное свойство (закрытое для чтения и открытое для записи)
        public int MyPrivateGetProperty { private get { return myVarieble; } set { myVarieble = value; } }

        // 3. Полное свойство (открытое для чтения и закрытое для записи)
        public int MyPrivateSetProperty { get { return myVarieble; } private set { myVarieble = value; } }

        // 4.  Свойство только для чтения
        public int MyGetProperty { get { return myVarieble; } }

        // 5. Свойство только для записи
        public int MySetProperty { set { myVarieble = value; } }

        // 1. Автосвойство (автоматически реализуемое свойство)
        public int MyAutoProperty { get; set; } = 1;

        // 2. Автосвойство  (закрытое для чтения и открытое для записи)
        public int MyPrivateGetAutoProperty { private get; set; } = 1;

        // 3. Автосвойство (открытое для чтения и закрытое для записи)
        public int MyPrivateSetAutoProperty { get; private set; } = 1;

        // 4. Автосвойство только для чтения
        public int MyGetAutoProperty { get; } = 1;

        // 5. Автосвойство только для записи не бывает
        // public int MySetAutoProperty { set; } = 1;

        // 1. Expression-Body свойство
        public int MyExpBodyProperty { get => myVarieble; set => myVarieble = value; }

        // 2. Expression-Body свойство (закрытое для чтения и открытое для записи)
        public int MyExpBodyPrivateGetProperty { private get => myVarieble; set => myVarieble = value; }

        // 3. Expression-Body свойство (открытое для чтения и закрытое для записи)
        public int MyExpBodyPrivateSetProperty { get => myVarieble; private set => myVarieble = value; }

        // 4. Expression-Body свойство только для чтения
        public int MyGetExpBodyProperty { get => myVarieble; }

        // 5. Упрощенное Expression-Body свойство только для чтения
        public int MySimpleGetExpBodyProperty => myVarieble;

        // 6. Expression-Body свойство только для записи
        public int MySetExpBodyProperty { set => myVarieble = value; }
    }
}
