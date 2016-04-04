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
        public string breed;
        public int foodType;
        public int foodQty;
        public cats(string petName, string petBreed, string shotStatus, int foodType, int foodAmount, int assignedCage)
        {
            animalName = petName;
            breed = petBreed;
            shots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            cageNumber = assignedCage;
        }
    }
}
