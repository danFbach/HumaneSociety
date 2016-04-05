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
        string filePath = @"C:/Users/Dan DCC/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSociety/";
        string animalFile = "animalInventory.csv";
        public void animalInventory(List<animals> animalsInStock)
        {
            using (StreamWriter saveDatabase = new StreamWriter(filePath + animalFile))
            {                
                foreach (animals pets in animalsInStock)
                {
                    
                        string name = pets.animalName;
                        string breed = pets.breed;
                        string shots = pets.healthShots;
                        int foodType = pets.foodType;
                        int foodQty = pets.foodQty;
                        int assignedCage = pets.cageNumber;
                    if (pets.GetType() == typeof(dogs))
                    {
                        saveDatabase.WriteLine("{0},{1},{2},{3},{4},{5}", name, breed, shots, foodType, foodQty, assignedCage);
                    }

                    if (pets.GetType() == typeof(cats))
                    {
                        saveDatabase.WriteLine("{0},{1},{2},{3},{4},{5}", name, breed, shots, foodType, foodQty, assignedCage);
                    }              
                }
            }
        }
    }
}
