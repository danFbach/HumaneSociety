using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class cat : animals
    {
        public cat(string petsName, string species, string shotStatus, int foodPreference, int foodQtyNeeds, int cageAssignment, int price)
        {
            priceOfAnimal = price;
            animalName = petsName;
            breed = species;
            healthShots = shotStatus;
            foodType = foodPreference;
            dailyFoodIntake = foodQtyNeeds;
            cageNumber = cageAssignment;
        }
    }
}
