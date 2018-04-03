using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式2
{
    public abstract class Manager
    {
        protected Manager manager;
        protected string name;

        public Manager(string name) {
            this.name = name;
        }

        public void SetManager(Manager manager) {
            this.manager = manager;
        }

        public abstract void HandlerRequest(Request request);
    }
}
