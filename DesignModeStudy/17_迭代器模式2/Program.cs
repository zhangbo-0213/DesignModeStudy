﻿using System;

namespace _17_迭代器模式2
{
    //foreach 内部实现
    // IEnumerator  e=a.GetEnumerator();
    //while(e.MoveNext()){
    //return e.Current;
    //}
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors= { "red", "green", "blue" };
            IEnumerable1<string> Colors = new IEnumerable1<string>(colors);

            foreach (var color in Colors) {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nIEnumerable2");
            IEnumerable2 colorIEnumerable2 = new IEnumerable2();
            foreach (string c in colorIEnumerable2.Color()) {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nIEnumerable3");
            IEnumerable3 colorIEnumerable3 = new IEnumerable3();
            foreach (string c in colorIEnumerable3)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
