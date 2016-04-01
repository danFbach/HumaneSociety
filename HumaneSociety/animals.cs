using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class animals
    {
        dogs modifyDogs;
        public bool checkAnswer = true;
        
        humaneSociety modifyAnimals = new humaneSociety();
        List<dogs> dogInventory = new List<dogs>();
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
        }
        
        public List<dogs> addNewDog()
        { 
            
            string petsName = modifyAnimals.petName();
            string shotStatus = modifyAnimals.animalShots();
            int foodSelection = modifyAnimals.foodType();
            int foodQtyNeeds = modifyAnimals.foodQTY();
            int cageSelection = modifyAnimals.cageNumber();
            dogInventory.Add(new dogs(petsName, shotStatus, foodSelection, foodQtyNeeds, cageSelection));
            return dogInventory;    
        }
        public List<cats> addNewCat()
        {

            return catInventory;
        }
    }
}
