using System;

namespace Convertor3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertorClass c1 = new ConvertorClass();
            c1.ConvertToOunces(5);
            Console.WriteLine(c1);
            Console.WriteLine("----------------");
            c1.ConvertToGrams(10);
            Console.WriteLine(c1);
            Console.WriteLine("----------------");
            Console.ReadLine();
        }
    }
}
