using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    public class Jane : Robot
    {
        public Jane(int generation)
        {
            this.name = askName();
            this.generation = generation;
        }
        public override void material()
        {
            base.material();
            Console.WriteLine("and also made out of aluminium");
        }

    }
}
