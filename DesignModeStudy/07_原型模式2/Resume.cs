using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式2
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private int age;

        private WorkExperience work;
        public Resume(string name) {
            this.name = name;
            work = new WorkExperience();
        }

        //提供克隆方法调用的private私有构造方法，便于克隆“工作经历数据”
        private Resume(WorkExperience work) {
            this.work = work.Clone() as WorkExperience;
        }

        public void SetInfo(string sex, int age) {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string workData, string company) {
            work.WorkData = workData;
            work.Company = company;
        }

        public void DisPlay() {
            Console.WriteLine("{0}  {1}  {2}",name,sex,age);
            Console.WriteLine("WorkExperience:  {0}    {1}",work.WorkData,work.Company);
        }
        public object Clone()
        {
            Resume obj=new Resume(this.work);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;
        }
    }
}
