using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式
{
    public class Context
    {
        private State state;
        public State State {
            get { return state; }
            set { state = value;
                Console.WriteLine("当前状态：{0}",state.GetType().Name);
            }
        }

        public Context(State state) {
            this.state = state;
        }

        public void Request() {
            state.Handle(this);
        }
    }
}
