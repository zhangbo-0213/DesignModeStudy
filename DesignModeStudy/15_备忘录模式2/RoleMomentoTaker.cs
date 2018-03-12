using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式2
{
    public class RoleMomentoTaker
    {
        private RoleStateMemento roleMomento; 

        public RoleStateMemento RoleMomento {
            get { return roleMomento; }
            set { roleMomento = value; }
        }
    }
}
