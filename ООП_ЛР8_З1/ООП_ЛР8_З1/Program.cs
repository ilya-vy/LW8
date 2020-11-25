using System;

namespace ООП_ЛР8_З1
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerClass indexerClass = new IndexerClass();
            Console.WriteLine("Укажите индекс вызываемого поля: ");
            Console.WriteLine(indexerClass[int.Parse(Console.ReadLine())]);
            Console.ReadKey();
        }
    }
}
