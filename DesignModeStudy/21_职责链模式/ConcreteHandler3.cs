﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else if (request != null) {
                handler.HandlerRequest(request);
            }
        }
    }
}
