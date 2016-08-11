using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    public class Steve : Robot
    {
        Robot robot = new Robot();
        public Steve(int generation)
        {
            this.name = askName();
            this.generation = generation;
            
        }
        public override void material()
        {
            Console.WriteLine("{0} is mostly made out of titanium", name);
            robot.question();
        }

        
    }
}
