using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    public class Steve : Robot
    {
        
        public Steve()
        {
            this.name = askName();
            generation = 4;
            
        }
        public virtual void setJob()
        {
            Console.WriteLine("{0} is a mechanic", name);

        }
        public override void setMaterial()
        {
            Console.WriteLine("{0} is mostly made out of titanium", name);
            setJob();
            this.askQuestion();
        }

        
    }
}
