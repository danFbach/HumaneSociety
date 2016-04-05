using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class cats : animals
    {
        public cats(string petsName, string species, string shotStatus, int foodType, int foodAmount, int cageAssignment)
        {
            animalName = petsName;
            breed = species;
            healthShots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            cageNumber = cageAssignment;
        }
    }
}
