using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIterator(ConcreteAggregate a) {
            aggregate = a;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >=aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret= null;
            current++;
            if (current < aggregate.Count) {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
