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
        int employeeAction;

        public int initial()
        {
            Console.WriteLine("Hello user, please identify what type of user are you? \n1) Customer \n2)Employee");
            answerCheck = int.TryParse(Console.ReadLine(), out userTypeMenu);
            if (answerCheck.Equals(false)) { return initial(); }
            switch (userTypeMenu)
            {
                case (1):
                    customerMenu();
                    return userTypeMenu;
                case (2):
                    modifyAnimals.employeeMenu();
                    return userTypeMenu; 
                default:
                    initial();
                    return userTypeMenu;
            }
        }
        public void customerMenu()
        {
            Console.WriteLine("Welcome the the Humane Society of awesome Animals. Please select one of the following options." +
                "\n1) View our pet catalog. \n2)Have us suggest a pet based on your preferences. \n3)Request a pet!");
            answerCheck = int.TryParse(Console.ReadLine(), out customerAction);
            if (answerCheck.Equals(false)) { customerMenu(); }
            switch (customerAction)
            {
                case (1):
                    return;
                case (2):
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
