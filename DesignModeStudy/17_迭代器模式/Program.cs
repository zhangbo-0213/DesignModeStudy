﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            Iterator i = a.CreateItrator();

            object item = i.First();
            while (!i.IsDone()) {
                Console.WriteLine("{0}  上车要买票", i.CurrentItem());
                i.Next();
            }

            Console.WriteLine("倒序遍历");

            Iterator i2= new ConcreteIteratorDesc(a);
            while (!i2.IsDone())
            {
                Console.WriteLine("{0}  上车要买票", i2.CurrentItem());
                i2.Next();
            }

            Console.ReadKey();
        }
    }
}
