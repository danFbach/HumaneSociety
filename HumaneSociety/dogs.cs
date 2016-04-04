using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class dogs : animals
    {
        public string shots;
        public int foodType;
        public int foodQty;
        public int playfulness;
        public dogs(string petsName, string species, string shotStatus, int foodType, int foodQty, int cageAssignment)
        {
            animalName = petsName;
            breed = species;
            shots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            //playfulness = playfulLevel();
            cageNumber = cageAssignment;
        }
        public int playfulLevel()
        {           
            int playLevel;
            Console.WriteLine("Please enter, using numbers 1-10, how playful the dog is.");
            bool checkAnswer = int.TryParse(Console.ReadLine(),out playLevel);
            if (checkAnswer.Equals(false)) { return playfulLevel(); }
            return playLevel;
        }
    }
}
