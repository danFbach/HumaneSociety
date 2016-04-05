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
        string line;
        string filePath = @"C:/Users/Dan DCC/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSociety/";
        string fileName = "animalInventory.csv";
        string petName;
        string breed;
        string shotStatus;
        string strFoodType;
        string strFoodQty;
        string strCageNumber;
        int foodType;
        int foodQty;
        int assignedCage;

        List<animals> animalInventory = new List<animals>();
        public List<animals> animalDatabase()
        {
            int cages = 0;
            int totalCages = 40;
            List<string> tempAnimalList = new List<string>();
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
                    foodType = Convert.ToInt16(strFoodType);
                    foodQty = Convert.ToInt16(strFoodQty);
                    assignedCage = Convert.ToInt16(strCageNumber);

                    for(; cages < (totalCages/2);)
                    { 
                        animalInventory.Add(new dogs(petName, breed, shotStatus, foodType, foodQty, assignedCage));
                        break;
                    }
                    for(;19 < cages && cages < totalCages;)
                    {
                        animalInventory.Add(new cats(petName, breed, shotStatus, foodType, foodQty, assignedCage));
                        break;
                    }
                    cages++;
                }
            }
            return animalInventory;
        }
    }
}
                //int cageNumber;
                
                //for (cageNumber = 0; cageNumber < (totalCages / 2); cageNumber++)
                //    {
                //        line = getAnimalData.ReadLine();
                        
                //    }
                //    for (; cageNumber < (totalCages); cageNumber++)
                //    {
                //        string[] decodeAnimals = line.Split(removal);
                //        petName = decodeAnimals[0];
                //        breed = decodeAnimals[1];
                //        shotStatus = decodeAnimals[2];
                //        strFoodType = decodeAnimals[3];
                //        strFoodQty = decodeAnimals[4];
                //        strCageNumber = decodeAnimals[5];
                //        foodType = Convert.ToInt16(strFoodType);
                //        foodQty = Convert.ToInt16(strFoodQty);
                //        assignedCage = Convert.ToInt16(strCageNumber);
                //        animalInventory.Add(new cats(petName, breed, shotStatus, foodType, foodQty, assignedCage));
                //    }
                
            

