using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式2
{
    public class Work
    {
        private State current;
        public Work(State state) {
            current = state;
        }

        private double hour;
        public double Hour {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;
        public bool TaskFinished {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State state) {
            current = state;
        }

        public void WriteProgram() {
            current.WriteProgram(this);
        }
    }
}
