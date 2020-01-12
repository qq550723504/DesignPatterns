using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var femalePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.GetGender().Equals("FEMALE", StringComparison.OrdinalIgnoreCase))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
