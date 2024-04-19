using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFirstHome.Model
{
    public class Lion : Animal
    {
        public bool IsPrideLeader {  get; set; }
        public Lion(string breed , bool isPrideLader) : base(breed)
        {
            IsPrideLeader = isPrideLader;
        }

        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("duzgun qida");
            }
            else
            {
                Console.WriteLine("Yalnis qida");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine(" siii siiiiiuuuu");
        }
    }
}
