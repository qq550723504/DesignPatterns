using System;
using System.Collections.Generic;

namespace FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Robert", "Male", "Single"),
                new Person("John", "Male", "Married"),
                new Person("Laura", "Female", "Married"),
                new Person("Diana", "Female", "Single"),
                new Person("Mike", "Male", "Single"),
                new Person("Bobby", "Male", "Single")
            };

            var male = new CriteriaMale();
            var female = new CriteriaFemale();
            var single = new CriteriaSingle();
            var singleMale = new AndCriteria(single, male);
            var singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males:");
            PrintPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales:");
            PrintPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males:");
            PrintPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females:");
            PrintPersons(singleOrFemale.MeetCriteria(persons));

            Console.ReadKey();
        }

        public static void PrintPersons(IList<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.Write($"Person : [ Name : {person.GetName()},");
                Console.Write($"Gender :{ person.GetGender()},");
                Console.WriteLine($" Marital Status :{person.GetMaritalStatus()}]");
            }
        }
    }
}
