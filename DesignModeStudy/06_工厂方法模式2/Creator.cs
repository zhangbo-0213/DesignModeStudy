using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂方法模式2
{
    public abstract class Creator
    {
        private List<Page> pages = new List<Page>();
        public List<Page> Pages {
            get {
                return pages;
            }
        }

        public Creator() {
            this.CreatePages();
        }

        public abstract void CreatePages();
    }
}
