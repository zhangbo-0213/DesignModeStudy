using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_观察者模式
{
    public class ConcreteSubject:Subject
    {
        private string subjectState;
        public string SubjectState {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
