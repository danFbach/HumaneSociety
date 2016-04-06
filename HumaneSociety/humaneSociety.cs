using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class humaneSociety
    {
        public List<animals> animalInventory = new List<animals>();
        fileWriter save = new fileWriter();
        fileReader load = new fileReader();
        animals animalModification = new animals();
        public bool answerCheck = true;
        public int animalType;
        public int employeeAction;
        bankAccount money = new bankAccount();
        public void employeeMenu()
        {
            Console.WriteLine("Welcome employeee, what are you here to do?" +
                "\n1) Add a new animal to the catalog. \n2) Remove an animal from catalog. \n3) See How much food we will need this week to feed all of the animals. \n4) Give an animal their shots.");
            answerCheck = int.TryParse(Console.ReadLine(), out employeeAction);
            if (answerCheck.Equals(false)) { employeeMenu(); }
            switch (employeeAction)
            {
                case (1):
                    selectAnimalType();
                    return;
                case (2):
                    getAvailableAnimals();
                    int animalRemoval = removeSelection();
                    removeAnimal(animalRemoval);
                    return;
                case (3):
                    foodCalculation();
                    return;
                case (4):
                    int balance = money.getMoney();
                    int animalCage;
                    getAvailableAnimals();
                    Console.WriteLine("Please Select the cage number of the animal that needs shots");
                    bool check = int.TryParse(Console.ReadLine(), out animalCage);
                    if (check.Equals(false)) { employeeMenu(); }
                    string shots = animalModification.giveShots(balance);
                    if (shots.Equals("y")) { animalInventory[animalCage].healthShots = "y"; }
                    save.animalInventory(animalInventory);
                    return;
                default:
                    return;
            }
        }
        public void loadAnimalData()
        {
            animalInventory = load.animalDatabase();
        }
        public int adoptAPet()
        {
            int adoptAnimal;
            Console.WriteLine("Please enter the cage number of the animal you would like to adopt.");
            bool check = int.TryParse(Console.ReadLine(), out adoptAnimal);
            if (check.Equals(false)) { Console.WriteLine("Invalid Response."); adoptAPet(); }
            return adoptAnimal;
        }
        public int removeSelection()
        {
            int remove;
            Console.WriteLine("Please Select the animal that needs to be removed.");
            bool check = int.TryParse(Console.ReadLine(), out remove);
            if (check.Equals(false)) { return removeSelection(); }
            return remove; 
        }
        public void removeAnimal(int removeCage)
        {
            if(removeCage<20)
            {
                animalInventory[removeCage] = (new dogs("name", "breed", "shot", 0, 0, removeCage, 0));
            }
            else if(removeCage >= 20 && removeCage < 40)
            {
                animalInventory[removeCage] = (new cats("name", "breed", "shot", 0, 0, removeCage, 0));
            }
            save.animalInventory(animalInventory);
            Console.WriteLine("The animal from cage " + removeCage + " has been removed from the database");
        }
        public void selectAnimalType()
        {
            bool checkAnswer = true;
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
        public void getAvailableAnimals()
        {
            int petType;
            Console.WriteLine("1) Dog \n2) Cat \nEnter your selection.");
            bool check = int.TryParse(Console.ReadLine(), out petType);
            if (check.Equals(false)) { Console.WriteLine("Invalid Selection."); getAvailableAnimals(); }

            foreach (animals pets in animalInventory)
            {
                if (pets.animalName != "name")
                {
                    if (petType.Equals(1))
                    {
                        if (pets.GetType() == typeof(dogs))
                        {
                            Console.WriteLine("Dog: " + pets.animalName + ", Breed: " + pets.breed + ", Medical Shots: " + pets.healthShots + ", Price: " + pets.priceOfAnimal.ToString("C2") + ", Cage: " + pets.cageNumber);
                        }
                    }
                    else if (petType.Equals(2))
                    {
                        if (pets.GetType() == typeof(cats))
                        {
                            Console.WriteLine("Cats: " + pets.animalName + ", Breed: " + pets.breed + ", Medical Shots: " + pets.healthShots + ", Price: " + pets.priceOfAnimal.ToString("C2") + ", Cage: " + pets.cageNumber);
                        }
                    }                    
                }
            }
        }
        public List<animals> addNewDog()
        {
            int HSBalance = money.getMoney();
            string petsName = animalModification.petName();
            string breed = animalModification.animalBreed();
            string shotStatus = animalModification.getAnimalShots(HSBalance);
            int foodSelection = animalModification.getFoodType();
            int foodQtyNeeds = animalModification.getFoodQTY();
            foreach (animals info in animalInventory)
            {
                if(info.GetType() == typeof(dogs))
                {
                    if (info.animalName == "name")
                    {
                        Console.Write(info.cageNumber + ", ");
                    }
                }                
            }
            int cageSelection = animalModification.getCageNumber();
            int petPrice = animalModification.setPrice();           
            animalInventory[cageSelection] = new dogs(petsName, breed, shotStatus, foodSelection, foodQtyNeeds, cageSelection, petPrice);
            save.animalInventory(animalInventory);        
            Console.ReadKey();
            return animalInventory;
        }
        
        public List<animals> addNewCat()
        {
            int HSBalance = money.getMoney();
            string petsName = animalModification.petName();
            string breed = animalModification.animalBreed();
            string shotStatus = animalModification.getAnimalShots(HSBalance);
            int foodSelection = animalModification.getFoodType();
            int foodQtyNeeds = animalModification.getFoodQTY();
            foreach (animals info in animalInventory)
            {
                if(info.GetType() == typeof(cats))
                {
                    if (info.animalName == "name")
                    {
                        Console.Write(info.cageNumber + ", ");
                    }
                }
            }
            int cageSelection = animalModification.getCageNumber();
            int petPrice = animalModification.setPrice();
            animalInventory[cageSelection] = new cats(petsName, breed, shotStatus, foodSelection, foodQtyNeeds, cageSelection, petPrice);
            save.animalInventory(animalInventory);
            return animalInventory;
        }
        public void foodCalculation()
        {
            int dogBeefOrder = 0;
            int dogFishOrder = 0;
            int dogChickenOrder = 0;
            int catBeefOrder = 0;
            int catFishOrder = 0;
            int catChickenOrder = 0;
            int aWeek = 7;
            foreach (animals pet in animalInventory)
            {
                int foodType = pet.foodType;
                int foodQty = pet.dailyFoodIntake;

                if (pet.GetType() == typeof(dogs))
                {
                    if (foodType == 1)
                    {
                        dogBeefOrder += foodQty;
                    }
                    else if (foodType == 2)
                    {
                        dogFishOrder += foodQty;
                    }
                    else if (foodType == 3)
                    {
                        dogChickenOrder += foodQty;
                    }
                }
                else if (pet.GetType() == typeof(cats))
                {
                    if (foodType == 1)
                    {
                        catBeefOrder += foodQty;
                    }
                    else if (foodType == 2)
                    {
                        catFishOrder += foodQty;
                    }
                    else if (foodType == 3)
                    {
                        catChickenOrder += foodQty;
                    }
                }                
            }
            dogBeefOrder = dogBeefOrder * aWeek; dogFishOrder = dogFishOrder * aWeek; dogChickenOrder = dogChickenOrder * aWeek;
            catBeefOrder = catBeefOrder * aWeek; catFishOrder = catFishOrder * aWeek; catChickenOrder = catChickenOrder * aWeek;

            Console.WriteLine("Dog food by flavor in cups/week. Beef: " + dogBeefOrder + ", Fish: " + dogFishOrder + ", Chicken: " + dogChickenOrder);
            Console.WriteLine("Cat food by flavor in cups/week. Beef: " + catBeefOrder + ", Fish: " + catFishOrder + ", Chicken: " + catChickenOrder);
        }
    }
}
