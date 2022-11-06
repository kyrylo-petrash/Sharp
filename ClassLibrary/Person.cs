namespace ClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public void Display()
        {
            Console.WriteLine($"{Name} {Id}");
        }
    }
}