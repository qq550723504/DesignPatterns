using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取唯一可用的对象
            var singleton = Singleton.GetUnSafeInstance();

            //显示消息
            singleton.ShowMessage();

            Console.WriteLine("Begin");
            MySingle.Instance.Age = 29;
            Console.WriteLine(MySingle.Instance.Age);

            Console.ReadKey();
        }
    }
}
