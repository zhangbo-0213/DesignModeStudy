﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式2
{
    public class Amativeness : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("{0}{1}时，凡事不懂也要装懂",man.GetType().Name,this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("{0}{1}时，遇事懂也要装不懂", woman.GetType().Name, this.GetType().Name);
        }
    }
}
