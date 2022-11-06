using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class MyProperties
    {
        // Title
        // характеристики (property) - поля и методы объекта
        string date = null; // свойство класса - это член, предоставляющий доступ к характеристике объекта или класса, свойства являются механизмом для чтения и записи полей объекта

        // 1 вариант
        public void SetData(string date) // метод (свойство) доступа класса
        {
            this.date = date.ToLower(); // тип значения this будет класс Invoice, this хранит адреса объектов класса в памяти
        }
        public string GetDate() // метод (свойство) доступа класса
        {
            return date;
        }

        // 2 вариант
        public string Date // свойство класса
        {
            set { date = value.ToLower(); } // value - хранение значения, которое присваивается полю
            get { return date; }
        }

        // string number= null;
        public string Number { get; set; } = null; // автосвойство, компилятор создаёт невидимое поле


        // string to = null;
        public string To { get; set; } = null;

        // string from = null;
        public string From { get; set; } = null;

        // Правка -> Выполнить рефакторинг -> Инкапсулировать поле (техника get set)
        public decimal Total
        {
            get => total; // return total
            set => total = value; // total = value
        }

        // Body
        // string[,] table = new string[17, 5];

        // Footer
        decimal total = 0;

        string strokeeperSurname = null;

        string forwarderSurname = null;
    }
}
