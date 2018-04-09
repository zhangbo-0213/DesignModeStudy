using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式2
{
    public class ObjectStructure
    {
        private IList<Person> persons = new List<Person>();

        public void Add(Person person) {
            persons.Add(person);
        }

        public void Remove(Person person) {
            persons.Remove(person);
        }

        public void Display(Action action) {
            foreach (Person p in persons) {
                p.Accept(action);
            }
        }
    }
}
