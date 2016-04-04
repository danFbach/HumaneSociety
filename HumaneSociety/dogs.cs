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
        public string breed;
        public int foodType;
        public int foodQty;
        public int playfulness;
        public dogs(string petName, string petBreed, string shotStatus, int foodType, int foodAmount, int assignedCage)
        {
            animalName = petName;
            breed = petBreed;
            shots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            //playfulness = playfulLevel();
            cageNumber = assignedCage;
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
