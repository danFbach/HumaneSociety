using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class dogs : animals
    {
        public int playfulness;
        public dogs(string petsName, string species, string shotStatus, int foodPrefence, int foodQtyNeeds, int cageAssignment, int price)
        {
            priceOfAnimal = price;
            animalName = petsName;
            breed = species;
            healthShots = shotStatus;
            foodType = foodPrefence;
            dailyFoodIntake = foodQtyNeeds;
            cageNumber = cageAssignment;
        }
    }
}
