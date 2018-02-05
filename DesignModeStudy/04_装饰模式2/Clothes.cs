using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式2
{
    public class Clothes:Person
    {
        protected Person person;
        public void WearClothes(Person person) {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null) {
                person.Show();
            }
        }
    }
}
