using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HumaneSociety
{
    public class fileReader
    {
        string filePath = @"C:/Users/Dan DCC/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSociety/";
        string clientFile = "clients.csv";
        string fileName = "animalInventory.csv";
        string moneyFile = "bankAccount.csv";
        string petName;
        string breed;
        string shotStatus;
        string strFoodType;
        string strFoodQty;
        string strCageNumber;
        string strPrice;
        int foodType;
        int foodQty;
        int assignedCage;
        int price;
        List<animals> animalInventory = new List<animals>();
        public List<animals> animalDatabase()
        {
            int cages = 0;
            int totalCages = 40;
            List<string> tempAnimalList = new List<string>();
            string line;
            char removal = ',';
            using (StreamReader getAnimalData = new StreamReader(filePath + fileName))
            {
                while ((line = getAnimalData.ReadLine()) != null)
                {
                    string[] decodeAnimals = line.Split(removal);
                    petName = decodeAnimals[0];
                    breed = decodeAnimals[1];
                    shotStatus = decodeAnimals[2];
                    strFoodType = decodeAnimals[3];
                    strFoodQty = decodeAnimals[4];
                    strCageNumber = decodeAnimals[5];
                    strPrice = decodeAnimals[6];
                    foodType = Convert.ToInt16(strFoodType);
                    foodQty = Convert.ToInt16(strFoodQty);
                    assignedCage = Convert.ToInt16(strCageNumber);
                    price = Convert.ToInt16(strPrice);

                    for(; cages < (totalCages/2);)
                    { 
                        animalInventory.Add(new dogs(petName, breed, shotStatus, foodType, foodQty, assignedCage, price));
                        break;
                    }
                    for(;19 < cages && cages < totalCages;)
                    {
                        animalInventory.Add(new cats(petName, breed, shotStatus, foodType, foodQty, assignedCage, price));
                        break;
                    }
                    cages++;
                }
            }
            return animalInventory;
        }
        public List<adopter> loadAdopters()
        {
            string line;
            char removal = ',';
            List<adopter> reloadAdopters = new List<adopter>();
            using(StreamReader getClients = new StreamReader(filePath + clientFile))
            {
                while((line = getClients.ReadLine()) != null)
                {
                    string[] decodeClients = line.Split(removal);
                    string firstName = decodeClients[0];
                    string lastName = decodeClients[1];
                    string strBreedPref = decodeClients[2];
                    string petName = decodeClients[3];
                    string petBreed = decodeClients[4];
                    int breedPref = Convert.ToInt16(strBreedPref);

                    reloadAdopters.Add(new adopter(firstName, lastName, breedPref, petName, petBreed));
                }
            }
            return reloadAdopters;
        }
        public int loadMoney()
        {
            string strbalance;
            int balance;
            using(StreamReader money = new StreamReader(filePath + moneyFile))
            {
                strbalance = money.ReadLine();
                balance = Convert.ToInt16(strbalance);
            }
            return balance;
        }
    }
}      
            

