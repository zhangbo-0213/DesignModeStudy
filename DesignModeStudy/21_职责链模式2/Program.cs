using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            CommanManager commanManager = new CommanManager("CommonManager");
            Majordomo majordomo = new Majordomo("Majordomo");
            GeneralManager generalManager = new GeneralManager("GeneralManager");

            commanManager.SetManager(majordomo);
            majordomo.SetManager(generalManager);

            Request request1 = new Request();
            request1.RequestType = "请假";
            request1.RequestContent = "编号5927 请假";
            request1.RequestNumber = 1;
            commanManager.HandlerRequest(request1);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "编号5927 请假";
            request2.RequestNumber = 4;
            commanManager.HandlerRequest(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "编号5927 加薪";
            request3.RequestNumber = 500;
            commanManager.HandlerRequest(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "编号5927 加薪";
            request4.RequestNumber = 1000;
            commanManager.HandlerRequest(request4);

            Console.ReadKey();
        }
    }
}
