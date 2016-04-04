using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class animals
    {
        public bool checkAnswer = true;        
        humaneSociety modifyAnimals = new humaneSociety();
        List<cats> catInventory = new List<cats>();

        public animals()
        {                       
        }
        public void selectAnimalType()
        {
            int typeOfAnimal;
            Console.WriteLine("Do you need to add a (1)cat or (2)dog to the inventory?");
            checkAnswer = int.TryParse(Console.ReadLine(), out typeOfAnimal);
            if (checkAnswer.Equals(false)) { selectAnimalType(); }
            if (typeOfAnimal.Equals(1))
            {
                addNewCat();
            }
            else if (typeOfAnimal.Equals(2))
            {
                addNewDog();
            }
            selectAnimalType();
        }
        
        public void addNewDog()
        { 
            
            string petsName = modifyAnimals.petName();
            string shotStatus = modifyAnimals.animalShots();
            int foodSelection = modifyAnimals.foodType();
            int foodQtyNeeds = modifyAnimals.foodQTY();
            int cageSelection = modifyAnimals.cageNumber();
        }
        public List<cats> addNewCat()
        {

            return catInventory;
        }
    }
}
