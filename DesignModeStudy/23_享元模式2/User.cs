using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式2
{
    public class User
    {
        private string name;
        public User(string name) {
            this.name = name;
        }

        public string Use {
            get { return name; }
        }
    }
}
