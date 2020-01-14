using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = CustomerFactory.GetCustomer("Rob");
            var customer2 = CustomerFactory.GetCustomer("Bob");
            var customer3 = CustomerFactory.GetCustomer("Julie");
            var customer4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers");
            Console.WriteLine(customer1.GetName());
            Console.WriteLine(customer2.GetName());
            Console.WriteLine(customer3.GetName());
            Console.WriteLine(customer4.GetName());

            Console.ReadKey();
        }
    }
}
