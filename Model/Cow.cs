using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFirstHome.Model
{
    public class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("duzgun qida");
                ProduceMilk();
            }
            else
            {
                Console.WriteLine("Yalnis qida");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mooooo mooooo");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced");
        }
    }
}
