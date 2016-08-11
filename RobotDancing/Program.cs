using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    class Program
    {
        static void Main(string[] args)
        {
            Jane girl = new Jane(2);
            Steve boy = new Steve(4);
            girl.material();
            boy.material();
            //girl.question();
        }
    }
}
