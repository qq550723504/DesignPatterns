using System;
using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.GetGender().Equals("MALE",StringComparison.OrdinalIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
