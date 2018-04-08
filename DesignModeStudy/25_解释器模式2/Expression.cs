using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_解释器模式2
{
    public abstract class Expression
    {
        public void Interpret(PlayContext playContext) {
            if (playContext.Text.Length == 0)
                return;
            else {
                string playKey = playContext.Text.Substring(0,1);
                playContext.Text = playContext.Text.Substring(2);
                double playValue = Convert.ToDouble(playContext.Text.Substring(0,playContext.Text.IndexOf(" ")));
                playContext.Text = playContext.Text.Substring(playContext.Text.IndexOf(" ")+1);

                Excute(playKey,playValue);
            }
        }
        public abstract void Excute(string playKey,double playValue);
    }
}
