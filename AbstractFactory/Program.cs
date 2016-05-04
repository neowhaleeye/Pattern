using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory fac1 = new AfricaFactory();
            ContinentFactory fac2 = new AmericanFactory();

            var aw = new AnimalWorld(fac1);
            aw.RunFoodChain();

            aw = new AnimalWorld(fac2);
            aw.RunFoodChain();

            Console.ReadKey();
        }
    }
}
