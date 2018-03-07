using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14适配器模式2
{
    public class ForeignCrnter
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public void AttackForForeign() {
            Console.WriteLine("外籍中锋{0}进攻",name);
        }

        public void DefenseForForeign() {
            Console.WriteLine("外籍中锋{0}防守",name);
        }
    }
}
