using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class people
    {
        public List<adopter> adopters = new List<adopter>();
        public people()
        {

        }
        public int newOrOldClient()
        {
            int clientIndex = 0;
            adopters.Add(new adopter("Dan","Fehrenbach", 2));
            int newOrOld = getTypeOfClient();
            if (newOrOld.Equals(1))
            {                
                clientIndex = addToClientList();
            }
            else if (newOrOld.Equals(2))
            {
                clientIndex = checkForClient();
            }
            if (clientIndex.Equals(-1))
            {
                return newOrOldClient();
            }
            else
            {
                return clientIndex;
            }            
        }
        public int addToClientList()
        {
            string clientFirstName = getFirstName();
            string clientLastName = getLastName();
            int getSpecies = getSpeciesPreference();
            adopters.Add(new adopter(clientFirstName, clientLastName, getSpecies));
            int clientIndex = (adopters.Count()) - 1;
            return clientIndex;
        }
        public int checkForClient()
        {
            Console.WriteLine("Please enter the last name that your account is registered under.");
            string clientCheck = Console.ReadLine();
            foreach(adopter information in adopters)
            {
                if (clientCheck.Equals(information.adopterLastName))
                {
                    return adopters.IndexOf(information);                    
                }
                else
                {
                    Console.WriteLine("The supplied name was not found in our database. Would you like to try searching again? (Y/N)");
                    string restartSearch = Console.ReadLine();
                    restartSearch = restartSearch.ToLower();
                    if (restartSearch.Equals("y")) { return checkForClient(); }
                    else if (restartSearch.Equals("n")) { return (-1); }
                    else { Console.WriteLine("Invalid Entry."); return checkForClient(); }
                }
            }
            return (-1);
        }
        public string getFirstName()
        {
            string clientFirst;
            Console.WriteLine("Hello, new customer, can you please enter your first name?");
            clientFirst = Console.ReadLine();
            Console.WriteLine("You have entered " + clientFirst + ", is this correct? (Y/N)");
            string nameCheck = Console.ReadLine();
            nameCheck = nameCheck.ToLower();
            if (nameCheck.Equals("n")) { return getFirstName(); }
            else if (nameCheck.Equals("y")) { return clientFirst; }
            else { Console.WriteLine("Invalid entry."); return getFirstName(); }
            
        }
        public string getLastName()
        {
            string clientLast;
            Console.WriteLine("Next, can you please enter your last name?");
            clientLast = Console.ReadLine();
            Console.WriteLine("You have entered " + clientLast + ", is this correct? (Y/N)");
            string nameCheck = Console.ReadLine();
            nameCheck = nameCheck.ToLower();
            if (nameCheck.Equals("n")) { return getFirstName(); }
            else if (nameCheck.Equals("y")) { return clientLast; }
            else { Console.WriteLine("Invalid entry."); return getFirstName(); }

        }
        public int getSpeciesPreference()
        {
            int species;
            Console.WriteLine("Please select the species in which you are interested in adoptng. \n1) Dogs \n2) Cats \n3) Reptiles");
            bool check = int.TryParse(Console.ReadLine(), out species);
            if (check.Equals(false)) { return getSpeciesPreference(); }
            if (species > 0 && species <= 3) { return species;}
            else { return getSpeciesPreference(); }
        }
        public int getTypeOfClient()
        {
            int clientType;
            Console.WriteLine("Welcome customer, are you a new or returning customer? \n1) New \n2) Returning.");
            bool check = int.TryParse(Console.ReadLine(), out clientType);
            if (check.Equals(false)) { Console.WriteLine("Invalid Entry."); return getTypeOfClient(); }
            return clientType;
        }
    }
}