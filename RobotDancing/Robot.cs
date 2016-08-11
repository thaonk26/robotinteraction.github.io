using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDancing
{
    public class Robot
    {
        public string name;
        public int generation;
        

        public Robot()
        {

        }
        public virtual void material()
        {
            Console.WriteLine("{0} is made out of metal", name);
        }
        
        public string askName()
        {
            Console.WriteLine("What will you call me master?");
            return Console.ReadLine(); 
        }
        public void question()
        {
            Console.WriteLine("Should they combine their metals together?");
            createBaby(Console.ReadLine());
        }
        public void createBaby(string newBaby)
        {
            if (newBaby == "yes")
            {
                Console.WriteLine("Congradulations! They have created a creature of unknown origins!");
            } else
            {
                Console.WriteLine("They just sit there until they rust because you're mean.");
            }
        }
    }
}
