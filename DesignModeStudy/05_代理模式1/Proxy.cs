using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式1
{
    public class Proxy : Subject
    {
        RealSubject subject;
        public void Request()
        {
            if (subject == null)
                subject = new RealSubject();
            subject.Request();
        }
    }
}
