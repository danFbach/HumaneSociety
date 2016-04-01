using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class humaneSociety
    {
        public bool answerCheck = true;
        public int animalType;
        public int employeeAction;
        bankAccount money = new bankAccount();
        public List<animals> animalInventory = new List<animals>();
        animals animals;

        
        public void employeeMenu()
        {
            Console.WriteLine("Welcome employeee, what are you here to do?" +
                "\n1) Add a new animal to the catalog. \n2)Remove an animal from catalog. \n3)Approve the sale of an animal.");
            answerCheck = int.TryParse(Console.ReadLine(), out employeeAction);
            if (answerCheck.Equals(false)) { employeeMenu(); }
            switch (employeeAction)
            {
                case (1):
                    return;
                case (2):
                    return;
                default:
                    return;
            }
        }
        //public List<animals> addAnimals()
        //{
        //    animalInventory.Add(new animals(dogs, cats));
        //}
        public string petName()
        {
            Console.WriteLine("What is the name of the pet?");
            string animalName = Console.ReadLine();
            if (animalName.Equals("")) { return petName(); }
            return animalName;
        }
        public string animalShots()
        {
            Console.WriteLine("Has the animal had it proper shots? (Y/N)");
            string shots = Console.ReadLine();
            if (!shots.Equals("n") || !shots.Equals("y")) { return animalShots(); }
            return shots;
        }
        public int foodType()
        {
            int foodSelect;
            Console.WriteLine("What flavor of food does this animal like?"
                + "\n1)Beef \n2)Fish \n3)Chicken \n4)Turkey");
            answerCheck = int.TryParse(Console.ReadLine(), out foodSelect);
            if (answerCheck.Equals(false)) { return foodType(); }
            return foodSelect;
        }
        public int foodQTY()
        {
            int foodAmount;
            Console.WriteLine("Please enter the daily quantity of food required in cups.");
            answerCheck = int.TryParse(Console.ReadLine(),out foodAmount);
            if (answerCheck.Equals(false)) { return foodQTY(); }
            return foodAmount;
        }
        public int cageNumber()
        {
            int cageNumberSelection;
            Console.WriteLine("Please select the number of an available cage for the pet.");
            answerCheck = int.TryParse(Console.ReadLine(), out cageNumberSelection);
            if (answerCheck.Equals(false)) { return cageNumber(); }
            return cageNumberSelection;
        }
    }
}
