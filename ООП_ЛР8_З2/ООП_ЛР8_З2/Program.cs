using System;

namespace ООП_ЛР8_З2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateIndexerClass dateIndexerClass = new DateIndexerClass();
            Console.WriteLine("Укажите количество дней: ");
            Console.WriteLine(dateIndexerClass[double.Parse(Console.ReadLine())]);
            Console.ReadKey();
        }
    }
    
}
