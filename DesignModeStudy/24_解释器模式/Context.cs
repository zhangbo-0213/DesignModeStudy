using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_解释器模式
{
    public class Context
    {
        private string input;
        public string Input {
            get { return input; }
            set { input = value; }
        }

        private string output;
        public string Output {
            get { return input; }
            set { input = value; }
        }
    }
}
