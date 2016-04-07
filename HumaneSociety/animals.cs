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
        public string petName()
        {
            Console.WriteLine("What is the name of the pet?");
            string animalName = Console.ReadLine();
            if (animalName.Equals("")) { return petName(); }
            return animalName;
        }
        public string animalBreed()
        {
            Console.WriteLine("Please enter one word to describe the pet. i.e. color, smelly, fluffy.");
            string breed = Console.ReadLine();
            if (breed.Equals(null)) { return animalBreed(); }
            else { return breed; }
        }
        public string getAnimalShots(int moneyBalance)
        {
            Console.WriteLine("Has the animal had its proper shots? (Y/N)");
            string shots = Console.ReadLine();
            shots = shots.ToLower();
            if (shots.Equals("y"))
            {
                return shots;
            }
            else if (shots.Equals("n"))
            {
                shots = giveShots(moneyBalance);
                return shots;
            }
            else { return getAnimalShots(moneyBalance); }
        }
        public string giveShots(int moneyBalance)
        {
            string shots;
            Console.WriteLine("Would you like to give this pet the necesary shots? (Y/N)\n\rIt will cost you $50.00. You currently have " + moneyBalance.ToString("C2") + " in your account.");
            string giveShot = Console.ReadLine();
            giveShot = giveShot.ToLower();
            if (giveShot.Equals("y"))
            {
                adjustMoney(moneyBalance, (-50));
                shots = "y";
                return shots;
            }
            else if (giveShot.Equals("n"))
            {
                Console.WriteLine("Ok, you will have to give them their shot later.");
                shots = "n";
                return shots;
            }
            else { return giveShots(moneyBalance); }
        }
        public void adjustMoney(int moneyBalance, int amountToChange)
        {
            bankAccount updateMoney = new bankAccount();
            moneyBalance += amountToChange;
            updateMoney.humaneSocietyAccount(moneyBalance);
        }
        public int getFoodType()
        {
            int foodSelect;
            Console.WriteLine("What flavor of food does this animal like?"
                + "\n\r1)Beef \n\r2)Fish \n\r3)Chicken");
            bool answerCheck = int.TryParse(Console.ReadLine(), out foodSelect);
            if (answerCheck.Equals(false)) { return getFoodType(); }
            if (foodSelect > 3) { Console.WriteLine("Invalid Selection."); return getFoodType(); }
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
        public int getCageNumber(List<int> availableCages)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int cageNumberSelection;
            Console.WriteLine("Please select the number of an available cage for the pet.");
            bool answerCheck = int.TryParse(Console.ReadLine(), out cageNumberSelection);
            if (answerCheck.Equals(false)) { return getCageNumber(availableCages); }
            Console.ForegroundColor = ConsoleColor.Red;
            if (!availableCages.Contains(cageNumberSelection)) { Console.WriteLine("Cage is not available, please select another."); return getCageNumber(availableCages); }
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
