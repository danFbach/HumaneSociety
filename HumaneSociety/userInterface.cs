using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class userInterface
    {
        people people = new people();
        humaneSociety modifyAnimals = new humaneSociety();
        bool answerCheck = true;
        int userTypeMenu;
        int customerAction;
        public int clientIndex;
        public void initialize()
        {
            modifyAnimals.loadAnimalData();
        }
        public int initial()
        {
            Console.ForegroundColor = ConsoleColor.White;
            initialize();
            Console.Clear();
            Console.WriteLine("Hello, please identify what type of user you are. \n1) Customer \n2) Employee \n3) Shut off computer.");
            answerCheck = int.TryParse(Console.ReadLine(), out userTypeMenu);
            if (answerCheck.Equals(false)) { return initial(); }
            switch (userTypeMenu)
            {
                case (1):
                    clientIndex = people.newOrOldClient();
                    customerMenu();
                    return initial();
                case (2):
                    modifyAnimals.employeeMenu();
                    return initial();
                case (3):
                    return userTypeMenu;
                default:
                    initial();
                    return initial();
            }
        }
        public void customerMenu()
        {
            bankAccount updateMoney = new bankAccount();
            string clientFirstName = people.adopters[clientIndex].adopterFirstName;
            string clientLastName = people.adopters[clientIndex].adopterLastName;
            int clientsPetPreference = people.adopters[clientIndex].speciesChoice;
            Console.WriteLine("Welcome "+ clientFirstName + ", to the Humane Society of awesome Animals. Please select one of the following options." +
                "\n\r1) View our pet catalog. \n\r2) Adopt a Pet! \n\r3) Exit to previous menu.");
            answerCheck = int.TryParse(Console.ReadLine(), out customerAction);
            if (answerCheck.Equals(false)) { customerMenu(); }
            switch (customerAction)
            {
                case (1):
                    modifyAnimals.getAvailableAnimals();
                    customerMenu();
                    break;
                case (2):
                    List<int> availablePets = new List<int>();
                    availablePets = modifyAnimals.getAvailableAnimals();
                    int petIndex = modifyAnimals.adoptAPet(availablePets);
                    Console.ForegroundColor = ConsoleColor.White;
                    string petName = modifyAnimals.animalInventory[petIndex].animalName;
                    string breed = modifyAnimals.animalInventory[petIndex].breed;
                    int petPrice = modifyAnimals.animalInventory[petIndex].priceOfAnimal;
                    string petType = modifyAnimals.getAnimalType(petIndex);
                    int currentBalance = updateMoney.getMoney();
                    int newBalance = currentBalance + petPrice;
                    updateMoney.humaneSocietyAccount(newBalance);
                    people.addAdoptedPet(clientIndex,petName,breed);
                    modifyAnimals.removeAnimal(petIndex);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} {1} just purchased a {3} {2} who's name is {4}.", clientFirstName, clientLastName, petType, breed, petName);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to return to main screen.");
                    Console.ReadKey();
                    break;
                case (3):
                    break;
                default:
                    customerMenu();
                    break;
            }
        }        
    }
}
