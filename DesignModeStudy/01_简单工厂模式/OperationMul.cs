﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_简单工厂模式
{
    public class OperationMul:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA * NumB;
            return result;
        }

    }
}
