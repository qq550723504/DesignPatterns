using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern
{
    public interface ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons);
    }
}
