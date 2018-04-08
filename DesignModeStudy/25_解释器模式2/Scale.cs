using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_解释器模式2
{
    public class Scale : Expression
    {
        public override void Excute(string playKey, double playValue)
        {
            string scale = "";
            switch (Convert.ToInt32(playValue)) {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write(scale);
        }
    }
}
