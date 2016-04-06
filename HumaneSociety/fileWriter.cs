using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HumaneSociety
{
    public class fileWriter
    {
        string animalFile = "animalInventory.csv";
        string clientFile = "clients.csv";
        string moneyFile = "bankAccount.csv";
        public void animalInventory(List<animals> animalsInStock)
        {
            using (StreamWriter saveDatabase = new StreamWriter(animalFile, false))
            {                
                foreach (animals pets in animalsInStock)
                {                    
                    string name = pets.animalName;
                    string breed = pets.breed;
                    string shots = pets.healthShots;
                    int foodType = pets.foodType;
                    int foodQty = pets.dailyFoodIntake;
                    int assignedCage = pets.cageNumber;
                    int petPrice = pets.priceOfAnimal;
                    if (pets.GetType() == typeof(dogs))
                    {
                        saveDatabase.WriteLine("{0},{1},{2},{3},{4},{5},{6}", name, breed, shots, foodType, foodQty, assignedCage, petPrice);
                    }

                    if (pets.GetType() == typeof(cats))
                    {
                        saveDatabase.WriteLine("{0},{1},{2},{3},{4},{5},{6}", name, breed, shots, foodType, foodQty, assignedCage, petPrice);
                    }              
                }
            }
        }
        public void saveClients(List<adopter> adopters)
        {
            using (StreamWriter clients = new StreamWriter(clientFile, false))
            {
                foreach(adopter person in adopters)
                {
                    string firstName = person.adopterFirstName;
                    string lastName = person.adopterLastName;
                    int petPreference = person.speciesChoice;
                    string petName = person.petName;
                    string petBreed = person.petBreed;

                    clients.WriteLine("{0},{1},{2},{3},{4}", firstName,lastName,petPreference,petName,petBreed);
                }
            }
        }
        public void bankAccount(int balance)
        {
            using(StreamWriter saveBalance = new StreamWriter(moneyFile))
            {
                saveBalance.Write(balance);
            }
        }
    }
}
