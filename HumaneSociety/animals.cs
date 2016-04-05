using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class animals
    {
        public string animalName;
        public string breed;
        public string healthShots;
        public int foodType;
        public int dailyFoodIntake;
        public int priceOfAnimal;
        public int cageNumber;
        public animals()
        {           

        }
        public string petName()
        {
            Console.WriteLine("What is the name of the pet?");
            string animalName = Console.ReadLine();
            if (animalName.Equals("")) { return petName(); }
            return animalName;
        }
        public string animalBreed()
        {
            Console.WriteLine("Please enter the animals breed.");
            string breed = Console.ReadLine();
            if (breed.Equals(null)) { return animalBreed(); }
            else { return breed; }
        }
        public string getAnimalShots(int moneyBalance)
        {
            Console.WriteLine("Has the animal had it proper shots? (Y/N)");
            string shots = Console.ReadLine();
            shots = shots.ToLower();
            if (shots.Equals("y"))
            {
                return shots;
            }
            else if (shots.Equals("n"))
            {
                Console.WriteLine("You'll need to give this pet the necesary shots. It will cost you $50.00. You currently have " + moneyBalance.ToString("C2") + " in your account.");
                string giveShot = Console.ReadLine();
                giveShot = giveShot.ToLower();
                if (giveShot.Equals("y"))
                {
                    shots = "y";
                    return shots;
                }
                else if (giveShot.Equals("n"))
                {
                    Console.WriteLine("Ok, you will have to give them their shot later.");
                    return shots;
                }
                else { return getAnimalShots(moneyBalance); }
                
            }
            else { return getAnimalShots(moneyBalance); }
        }
        public int getFoodType()
        {
            int foodSelect;
            Console.WriteLine("What flavor of food does this animal like?"
                + "\n1)Beef \n2)Fish \n3)Chicken");
            bool answerCheck = int.TryParse(Console.ReadLine(), out foodSelect);
            if (answerCheck.Equals(false)) { return getFoodType(); }
            if(foodSelect > 3) { Console.WriteLine("Invalid Selection."); return getFoodType(); }
            return foodSelect;
        }
        public int getFoodQTY()
        {
            int foodAmount;
            Console.WriteLine("Please enter the daily quantity of food required in cups.");
            bool answerCheck = int.TryParse(Console.ReadLine(), out foodAmount);
            if (answerCheck.Equals(false)) { return getFoodQTY(); }
            return foodAmount;
        }
        public int getCageNumber()
        {
            int cageNumberSelection;
            Console.WriteLine("Please select the number of an available cage for the pet.");
            bool answerCheck = int.TryParse(Console.ReadLine(), out cageNumberSelection);
            if (answerCheck.Equals(false)) { return getCageNumber(); }
            return cageNumberSelection;
        }
        public int setPrice()
        {
            int setPetPrice;
            Console.WriteLine("Please enter the price that you would like to sell this pet for.");
            bool answerCheck = int.TryParse(Console.ReadLine(), out setPetPrice);
            if (answerCheck.Equals(false)) { return setPrice(); }
            return setPetPrice;
        }
    }
}
