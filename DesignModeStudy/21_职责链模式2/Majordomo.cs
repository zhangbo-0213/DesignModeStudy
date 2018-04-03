using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式2
{
    public class Majordomo : Manager
    {
        public Majordomo(string name) : base(name) { }
        public override void HandlerRequest(Request request)
        {
            if (request.RequestType == "请假" && request.RequestNumber <= 5)
            {
                Console.WriteLine("{0}：{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNumber);
            }
            else {
                if (manager != null)
                    manager.HandlerRequest(request);
            }
        }
    }
}
