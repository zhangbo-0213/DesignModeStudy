﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式
{
    public class Originator
    {
        private string state;
        public string State {
            get { return state; }
            set { state = value; }
        }

        public Memento CreateMemento() {
            return new Memento(state);
        }

        public void SetMemento(Memento memento) {
            state = memento.State;
        }

        public void Show() {
            Console.WriteLine("State:{0}",state);
        }
    }
}
