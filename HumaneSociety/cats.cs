using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class cats : animals
    {
        public string shots;
        public int foodType;
        public int foodQty;
        public cats(string petsName, string species, string shotStatus, int foodType, int foodQty, int cageAssignment)
        {
            animalName = petsName;
            breed = species;
            shots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            cageNumber = cageAssignment;
        }
    }
}
