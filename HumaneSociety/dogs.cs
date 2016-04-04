using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class dogs : animals
    {

        List<dogs> dogInventory = new List<dogs>();
        bool answerCheck;
        public string animalName;
        public string shots;
        public string breed;
        public int foodType;
        public int foodQty;
        public int cageNumber;
        public int playfulness;
        public dogs(string petName, string shotStatus, int foodType, int foodAmount, int assignedCage, int playfulness)
        {
            
            animalName = petName;
            shots = shotStatus;
            this.foodType = foodType;
            foodQty = foodAmount;
            playfulness = playfulLevel();
            cageNumber = assignedCage;
            updateDogs();
        }
        public int playfulLevel()
        {
            
            int playLevel;
            Console.WriteLine("Please enter, using numbers 1-10, how playful the dog is.");
            checkAnswer = int.TryParse(Console.ReadLine(),out playLevel);
            if (checkAnswer.Equals(false)) { return playfulLevel(); }
            return playLevel;
        }
        public void updateDogs()
        {
            dogInventory.Add(new dogs(animalName, shots, this.foodType, foodQty, playfulness, cageNumber));
        }
    }
}
