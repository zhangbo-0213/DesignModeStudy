using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_组合模式2
{
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name):base(name) {

        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
            foreach (Company company in children) {
                company.Display(depth+2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company company in children) {
                company.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }
    }
}
