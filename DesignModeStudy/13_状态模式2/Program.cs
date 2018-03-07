using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Work emergencyWork = new Work(new ForenoonState());
            emergencyWork.Hour = 9;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 12;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 13;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 14;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 17;
            emergencyWork.WriteProgram();

            emergencyWork.TaskFinished = false;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 19;
            emergencyWork.WriteProgram();
            emergencyWork.Hour = 22;
            emergencyWork.WriteProgram();

            Console.ReadKey();
        }
    }
}
