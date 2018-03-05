using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    public class Department
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }
    }
}
