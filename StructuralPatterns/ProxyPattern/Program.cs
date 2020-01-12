using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new ProxyImage("test_10mb.jpg");

            Console.WriteLine();

            // 图像将从磁盘加载
            image.Display();

            Console.WriteLine();

            // 图像不需要从磁盘加载
            image.Display();

            Console.ReadKey();
        }
    }
}
