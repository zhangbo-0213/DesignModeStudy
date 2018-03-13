using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_组合模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany cmp = new ConcreteCompany("上海华东分公司");
            cmp.Add(new HRDepartment("华东分公司人力资源部"));
            cmp.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(cmp);

            ConcreteCompany cmp2 = new ConcreteCompany("南京办事处");
            cmp2.Add(new HRDepartment("南京办事处人力资源部"));
            cmp2.Add(new FinanceDepartment("南京办事处财务部"));
            root.Add(cmp2);

            ConcreteCompany cmp3 = new ConcreteCompany("杭州办事处");
            cmp3.Add(new HRDepartment("杭州办事处人力资源部"));
            cmp3.Add(new FinanceDepartment("杭州办事处财务部"));
            root.Add(cmp3);

            Console.WriteLine("\n结构图：");
            root.Display(1);

            Console.WriteLine("\n职责");
            root.LineOfDuty();

            Console.ReadKey();
        }
    }
}
