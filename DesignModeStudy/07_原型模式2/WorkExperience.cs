using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式2
{
    public class WorkExperience : ICloneable
    {
        private string workData;
        public string WorkData {
            get { return workData; }
            set { workData = value; }
        }

        private string company;
        public string Company {
            get { return company; }
            set { company = value; }
        }
        public object Clone()
        {
            return this.MemberwiseClone() as object;
        }
    }
}
