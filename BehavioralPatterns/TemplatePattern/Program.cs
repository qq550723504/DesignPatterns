using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();

            Console.WriteLine();
            game = new Football();
            game.Play();

            Console.ReadKey();
        }
    }
}
