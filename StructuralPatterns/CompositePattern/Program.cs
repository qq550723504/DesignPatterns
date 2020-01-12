using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceo = new Employee("John", "CEO", 30000);

            var headSales = new Employee("Robert", "Head Sales", 20000);

            var headMarketing = new Employee("Michel", "Head Marketing", 20000);

            var clerk1 = new Employee("Laura", "Marketing", 10000);
            var clerk2 = new Employee("Bob", "Marketing", 10000);

            var salesExecutive1 = new Employee("Richard", "Sales", 10000);
            var salesExecutive2 = new Employee("Rob", "Sales", 10000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            //打印该组织的所有员工
            Console.WriteLine(ceo);
            foreach (Employee headEmployee in ceo.GetSubordinates())
            {
                Console.WriteLine(headEmployee);
                foreach (Employee employee in headEmployee.GetSubordinates())
                {
                    Console.WriteLine(employee);
                }
            }

            Console.ReadKey();
        }
    }
}
