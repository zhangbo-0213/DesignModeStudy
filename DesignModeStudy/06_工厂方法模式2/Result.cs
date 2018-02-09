using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂方法模式2
{
    public class Result : Creator
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroducationPage());
            Pages.Add(new SkillPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
