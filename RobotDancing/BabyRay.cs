using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    public class BabyRay : Steve
    {
        
        public BabyRay()
        {
            generation = 5;            
        }
        public override void setJob()
        {
            base.setJob();
            Console.WriteLine("but only changes the oil");
        }
    }
}
