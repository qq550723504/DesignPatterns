using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var robert = new User("Robert");
            var john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");

            Console.ReadKey();
        }
    }
}
