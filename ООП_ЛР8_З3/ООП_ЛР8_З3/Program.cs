using System;

namespace ООП_ЛР8_З3
{
    class Program
    {
        static void Main(string[] args)
        {   
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine("Input char index");
            char index = char.Parse(Console.ReadLine());
            Console.WriteLine("Input char value");
            char value = char.Parse(Console.ReadLine());
            derivedClass[index] = value;

            Console.WriteLine("Index {0} value: {1}", index, derivedClass[index]);
            Console.WriteLine("Array length: {0} CharArray length: {1}", derivedClass.ArrLength[0], derivedClass.ArrLength[1]);

            Console.ReadKey();
        }
    }
}
