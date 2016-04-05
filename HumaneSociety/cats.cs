using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class cats : animals
    {
        public cats(string petsName, string species, string shotStatus, int foodKind, int foodAmount, int cageAssignment, int price)
        {
            priceOfAnimal = price;
            animalName = petsName;
            breed = species;
            healthShots = shotStatus;
            foodType = foodKind;
            dailyFoodIntake = foodAmount;
            cageNumber = cageAssignment;
        }
    }
}
