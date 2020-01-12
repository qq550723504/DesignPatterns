using System.Collections.Generic;

namespace CompositePattern
{
    public class Employee
    {
        private readonly string Name;
        private readonly string Dept;
        private readonly int Salary;
        private readonly IList<Employee> Subordinates;

        public Employee(string name, string dept, int salary)
        {
            Name = name;
            Dept = dept;
            Salary = salary;
            Subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public IList<Employee> GetSubordinates()
        {
            return Subordinates;
        }

        public override string ToString()
        {
            return $"Employee :[ Name : {Name}, dept : {Dept}, salary :{Salary} ]";
        }
    }
}
