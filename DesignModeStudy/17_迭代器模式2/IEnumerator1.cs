using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式2
{
    public class IEnumerator1<T> : IEnumerator<T>
    {

        private int position = -1;
        private T[] t;

        public IEnumerator1(T[] a){
            t = new T[a.Length];
            for (int i = 0; i < a.Length; i++) {
                t[i] = a[i];
            }
        }

        public T Current {
            get {
                if (position == -1)
                    throw new InvalidOperationException();
                return t[position];
            }
        }

        object IEnumerator.Current {
            get
            {
                if (position == -1)
                    throw new InvalidOperationException();
                return t[position];
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            Console.WriteLine("Call Move Next");
            if (position <t.Length-1)
            {
                position++;
                return true;
            }
            else {               
                return false;
            }
        }

        public void Reset()
        {
            position=-1;
        }
    }
}
