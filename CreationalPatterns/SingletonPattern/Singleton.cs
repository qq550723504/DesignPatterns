using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(()=>new Singleton());
        private Singleton() { }

        /// <summary>
        /// 多线程不安全实现
        /// </summary>
        /// <returns></returns>
        public static Singleton GetUnSafeInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        /// <summary>
        /// 多线程安全实现
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSafeInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
        /// <summary>
        /// 只读属性式实现
        /// </summary>
        public static Singleton GetReadOnlyInstance { get; } = new Singleton();
        /// <summary>
        /// Lazy实现
        /// </summary>
        public static Singleton GetLazyInstance => lazyInstance.Value;

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

    }
}
