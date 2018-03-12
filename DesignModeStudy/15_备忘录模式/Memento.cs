using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式
{
    public class Memento
    {
        private string state;

        public Memento(string state) {
            this.state = state;
        }

        public String State {
            get { return state; }
        }
    }
}
