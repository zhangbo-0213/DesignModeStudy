using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式2
{
    public class IEnumerable1<T> : IEnumerable<T>
    {
        private T[] t;
        
        public IEnumerable1(T[] a) {
            t = new T[a.Length];
            for (int i = 0; i < a.Length; i++) {
                t[i] = a[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new IEnumerator1<T>(t);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new IEnumerator1<T>(t);
        }
    }
}
