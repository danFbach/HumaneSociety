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
            //modifyAnimals.makeCages(40);
        }

        public int initial()
        {
            Console.Clear();
            Console.WriteLine("Hello user, please identify what type of user are you? \n1) Customer \n2) Employee");
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
                default:
                    initial();
                    return initial();
            }
        }
        public void customerMenu()
        {
            
            string currentClientName = people.adopters[clientIndex].adopterFirstName;
            int clientsPetPreference = people.adopters[clientIndex].speciesChoice;
            Console.WriteLine("Welcome "+ currentClientName + ", to the Humane Society of awesome Animals. Please select one of the following options." +
                "\n1) View our pet catalog. \n2) Adopt a Pet! \n3) Request a pet!");
            answerCheck = int.TryParse(Console.ReadLine(), out customerAction);
            if (answerCheck.Equals(false)) { customerMenu(); }
            switch (customerAction)
            {
                case (1):
                    modifyAnimals.getAvailableAnimals();
                    return;
                case (2):
                    modifyAnimals.getAvailableAnimals();
                    modifyAnimals.adoptAPet();
                    return;
                case (3):
                    return;
                default:
                    customerMenu();
                    return;
            }
        }
        
    }
}
