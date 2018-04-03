using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式
{
    public abstract class Handler
    {
        protected Handler handler;

        public void SetHandler(Handler handler) {
            this.handler = handler;
        }

        public abstract void HandlerRequest(int request);
    }
}
