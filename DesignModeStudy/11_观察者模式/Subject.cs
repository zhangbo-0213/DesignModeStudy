using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_观察者模式
{
    public abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer) {
            observers.Add(observer);
        }

        public void Detach(Observer observer) {
            observers.Remove(observer);
        }

        public void Notify() {
            foreach (Observer observer in observers) {
                observer.Update();
            }
        }
    }
}
