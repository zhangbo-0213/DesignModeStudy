﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式
{
    public abstract class Prototype
    {
        private string id;

        public Prototype(string id) {
            this.id = id;
        }

        public string Id {
            get { return id; }
        }

        public abstract Prototype Clone();
    }
}
