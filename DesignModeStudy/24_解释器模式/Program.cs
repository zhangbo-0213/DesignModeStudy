using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_解释器模式
{
    class Program
    {
        //客户端用于构建文法定义的语言中一个特定的句子的抽象语法树
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpression> abstractExpression = new List<AbstractExpression>();
            abstractExpression.Add(new TerminalExpression());
            abstractExpression.Add(new NonterminalExpression());
            abstractExpression.Add(new TerminalExpression());
            abstractExpression.Add(new TerminalExpression());

            foreach (AbstractExpression abs in abstractExpression) {
                abs.Interpret(context);
            }

            Console.ReadKey();
        }
    }
}
