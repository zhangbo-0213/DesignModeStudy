using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_解释器模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext playContext = new PlayContext();
            Console.WriteLine("上海滩：");
            playContext.Text = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3";
            Expression expression = null;
            try {
                while (playContext.Text.Length > 0) {
                    string str = playContext.Text.Substring(0, 1);
                    switch (str) {
                        case "O":
                            expression = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                            expression = new Note();
                            break;
                    }
                    expression.Interpret(playContext);
                    Console.WriteLine();
                }              
         }
       catch (Exception ex)
        {
         Console.WriteLine(ex.Message);
        }
            Console.ReadKey();
        }
    }
}
