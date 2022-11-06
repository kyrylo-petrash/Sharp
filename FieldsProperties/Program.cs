using MyPackage;

namespace FieldsProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProperties invoice = new MyProperties();

            // ЗАПОЛНЕНИЕ ПОЛЕЙ

            // заголовок (Title)
            invoice.SetData("Дата 23 апреля 2070 года"); // 1 вариант
            invoice.Date = "Дата 23 апреля 2070 года"; // 2 вариант

            // тело (Body)

            // нижний колонтикул (Footer)

            // ЧТЕНЕИЕ ПОЛЕЙ

            // заголовок (Title)
            string date = invoice.GetDate(); // 1 вариант
            Console.WriteLine(date);
            date = invoice.Date; // 2 вариант
            Console.WriteLine(date);

            // тело (Body)

            // нижний колонтикул (Footer)
        }
    }
}