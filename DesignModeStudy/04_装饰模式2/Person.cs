using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式2
{
    public class Person
    {
        private string name;
        public Person() {

        }
        public Person(string name) {
            this.name = name;
        }

        public virtual void Show() {
            Console.WriteLine("装扮的是：{0}",name);
        }
    }
}
