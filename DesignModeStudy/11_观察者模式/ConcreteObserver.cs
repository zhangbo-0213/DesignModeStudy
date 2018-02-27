using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_观察者模式
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject concreteSubject;

        public ConcreteObserver(ConcreteSubject concreteSubject,string name) {
            this.concreteSubject = concreteSubject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = concreteSubject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是：{1}",name,observerState);
        }
    }
}
