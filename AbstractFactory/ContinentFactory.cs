using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbvore();
        public abstract Carnivore CreateCarnivore();
    }
}
