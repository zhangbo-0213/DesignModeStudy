﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂方法模式
{
    public class FactoryProductB : IFactory
    {
        public Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
