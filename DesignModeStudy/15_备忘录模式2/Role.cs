using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式2
{
    public class Role
    {
        private int hea;
        public int Hea {
            get { return hea; }
            set { hea = value; }
        }

        private int atk;
        public int Atk {
            get { return atk; }
            set { atk = value; }
        }

        private int def;
        public int Def {
            get { return def; }
            set { def = value; }
        }

        public RoleStateMemento CreateRoleMemento() {
            return new RoleStateMemento(hea, atk, def);
        }

        public void SetStateMemento(RoleStateMemento roleStateMemento) {
            this.atk = roleStateMemento.Atk;
            this.hea = roleStateMemento.Hea;
            this.def = roleStateMemento.Def;
        }

        public void ShowState() {
            Console.WriteLine("HeaState:{0}\nAtkState:{1}\nDefState{2}\n",hea,atk,def);
        }
    }
}
