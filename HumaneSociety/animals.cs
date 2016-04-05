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
        public int foodQty;
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
        public string getAnimalShots()
        {
            Console.WriteLine("Has the animal had it proper shots? (Y/N)");
            string shots = Console.ReadLine();
            if (shots.Equals("y"))
            {
                return shots;
            }
            else if (shots.Equals("n"))
            {
                //TODO function for giving animal shots
                return getAnimalShots();
            }
            else { return getAnimalShots(); }
        }
        public int getFoodType()
        {
            int foodSelect;
            Console.WriteLine("What flavor of food does this animal like?"
                + "\n1)Beef \n2)Fish \n3)Chicken \n4)Turkey");
            bool answerCheck = int.TryParse(Console.ReadLine(), out foodSelect);
            if (answerCheck.Equals(false)) { return getFoodType(); }
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
