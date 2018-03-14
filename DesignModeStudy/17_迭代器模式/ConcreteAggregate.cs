using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateItrator()
        {
            return new ConcreteIterator(this);
        }

        public int Count {
            get { return items.Count; }
        }

        public object this[int index] {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
