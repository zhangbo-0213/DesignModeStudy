using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14适配器模式2
{
    public abstract class Player
    {
        protected string name;
        public Player(string name) {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}
