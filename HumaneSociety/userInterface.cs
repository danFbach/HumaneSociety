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
                    Console.ReadKey();
                    return initial();
                case (2):
                    modifyAnimals.employeeMenu();
                    Console.ReadKey();
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
            string currentClientName = people.adopters[clientIndex].adopterFirstName;
            int clientsPetPreference = people.adopters[clientIndex].speciesChoice;
            Console.WriteLine("Welcome "+ currentClientName + ", to the Humane Society of awesome Animals. Please select one of the following options." +
                "\n1) View our pet catalog. \n2) Adopt a Pet! \n3) Exit to previous menu.");
            answerCheck = int.TryParse(Console.ReadLine(), out customerAction);
            if (answerCheck.Equals(false)) { customerMenu(); }
            switch (customerAction)
            {
                case (1):
                    modifyAnimals.getAvailableAnimals();
                    customerMenu();
                    break;
                case (2):
                    modifyAnimals.getAvailableAnimals();
                    int petIndex = modifyAnimals.adoptAPet();
                    string petName = modifyAnimals.animalInventory[petIndex].animalName;
                    string breed = modifyAnimals.animalInventory[petIndex].breed;
                    int petPrice = modifyAnimals.animalInventory[petIndex].priceOfAnimal;
                    int currentBalance = updateMoney.getMoney();
                    int newBalance = currentBalance + petPrice;
                    updateMoney.humaneSocietyAccount(newBalance);
                    people.addAdoptedPet(clientIndex,petName,breed);
                    modifyAnimals.removeAnimal(petIndex);
                    Console.WriteLine(currentClientName + " " + people.adopters[clientIndex].adopterLastName + " just purchased a " + breed + " who's name is " + petName + ".");
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
