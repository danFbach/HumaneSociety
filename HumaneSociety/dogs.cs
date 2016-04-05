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
        public dogs(string petsName, string species, string shotStatus, int foodType, int foodAmount, int cageAssignment, int price)
        {
            priceOfAnimal = price;
            animalName = petsName;
            breed = species;
            healthShots = shotStatus;
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
