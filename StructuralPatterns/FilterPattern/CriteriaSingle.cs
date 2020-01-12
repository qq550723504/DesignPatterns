using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaSingle : ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.GetMaritalStatus().Equals("SINGLE", StringComparison.OrdinalIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
