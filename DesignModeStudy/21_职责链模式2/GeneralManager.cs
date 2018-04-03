using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式2
{
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name) { }
        public override void HandlerRequest(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine("{0}：{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNumber);
            }
            else if (request.RequestType =="加薪" && request.RequestNumber <= 500) {
                Console.WriteLine("{0}：{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNumber);
            }
            else if (request.RequestType == "加薪" && request.RequestNumber > 500)
            {
                Console.WriteLine("{0}：{1} 数量{2} 再说吧", name, request.RequestContent, request.RequestNumber);
            }
        }
    }
}
