using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14适配器模式2
{
    public class Translator:Player
    {
        private ForeignCrnter fc = new ForeignCrnter();
        public Translator(string name):base(name) {
            fc.Name = name;
        }
        public override void Attack()
        {
            fc.AttackForForeign();
        }

        public override void Defense()
        {
            fc.DefenseForForeign();
        }

    }
}
