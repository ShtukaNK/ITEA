using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Aviory
    {
        public Animal animal;
        public Plant plant;

        public void PlaceAnimal (Animal animal)
        {

        }

        public void PlacePlant (Plant plant)
        {

        }

        public string GetStatus()
        {

            if (animal != null)
                Console.WriteLine ("Creature is here");

            if (plant != null)
                Console.WriteLine("Green thing is present");

            return "Nothing is here";

        }

    }
}
