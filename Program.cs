using SecondFirstHome.Model;

namespace SecondFirstHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow("country");
            Lion lion = new Lion("caunn",true);

            Animal[] animals = new Animal[] { cow, lion };

            foreach (var animal in animals)
            {
                if (animal is Lion lio)
                {
                    Meat meat = new Meat(1500, "honey");
                    lio.EatFood(meat);
                    lio.MakeSound();
                    Console.WriteLine(lio.Breed);
                }
                else if (animal is Cow co)
                {
                    Grass grass = new(900, "Ot");
                    co.EatFood(grass);
                    co.ProduceMilk();
                    co.MakeSound();
                    Console.WriteLine(co.Breed);
                }
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
