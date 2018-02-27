using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver(concreteSubject,"X"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject,"Y"));

            concreteSubject.SubjectState = "ABC";
            concreteSubject.Notify();

            Console.ReadKey();
        }
    }
}
