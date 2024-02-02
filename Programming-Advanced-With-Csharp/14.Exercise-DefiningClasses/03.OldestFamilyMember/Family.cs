using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People { get; set; }

        public Family()
        {
            People = people;
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember(List<Person> People)
        {
           Person oldestPerson = People.OrderByDescending(p => p.Age).First();

        return oldestPerson;
        }
    }
}
