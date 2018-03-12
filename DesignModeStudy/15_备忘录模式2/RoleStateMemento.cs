using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式2
{
    public class RoleStateMemento
    {
        private int hea;
        private int atk;
        private int def;

        public RoleStateMemento(int hea,int atk,int def) {
            this.hea = hea;
            this.atk = atk;
            this.def = def;
        }

        public int Hea {
            get { return hea; }
        }

        public int Atk {
            get { return atk; }
        }

        public int Def {
            get { return def; }
        }
    }
}
