using AbstractClass.Models;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(true);
            Console.WriteLine(bmw);
        }
    }
}