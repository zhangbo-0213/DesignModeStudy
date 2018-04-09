using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式
{
    public class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Add(Element element) {
            elements.Add(element);
        }

        public void Remove(Element element) {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor) {
            foreach (Element e in elements) {
                e.Accept(visitor);
            }
        }
    }
}
