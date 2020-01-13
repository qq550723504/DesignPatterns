using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesRepository = new NameRepository();

            for (var iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                var name = iter.Next();
                Console.WriteLine($"Name : {name}");
            }

            Console.ReadKey();
        }
    }
}
