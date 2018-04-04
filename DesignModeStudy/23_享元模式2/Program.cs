using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteFactory websiteFactory = new WebsiteFactory();
            Website concreteWebsite1 = websiteFactory.GetWebsite("产品展示");
            concreteWebsite1.Use(new User("MajorTom"));

            Website concreteWebsite2 = websiteFactory.GetWebsite("产品展示");
            concreteWebsite2.Use(new User("GroundControl"));

            Website concreteWebsite3 = websiteFactory.GetWebsite("产品展示");
            concreteWebsite3.Use(new User("Bobo"));

            Website concreteWebsite4 = websiteFactory.GetWebsite("博客论坛");
            concreteWebsite4.Use(new User("Major"));

            Website concreteWebsite5 = websiteFactory.GetWebsite("博客论坛");
            concreteWebsite5.Use(new User("Tom"));

            Console.WriteLine("实际实例个数：{0}", websiteFactory.GetCounts());

            Console.ReadKey();
            
        }
    }
}
