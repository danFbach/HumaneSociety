using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Program
    {
        static void Main(string[] args)
        {
            userInterface run = new userInterface();
        }
    }
}
//Requirements:
//    Console Application
//    Must be able to add an animal to the system
//    Must be able to remove an animal from the system and collect money from an adopter(object adopting an animal)
//    Must be able to track which animals have had their shots and give animals their shots if have not received it yet
//    Must be able to track animals in the system
//    Must be able to categorize animals in the system.This also involves which cage the animal is located in.
//    Adopters should have a profile.If an adopter adopts an animal, it should say which animal in the system. That means the same animal must be removed from the system.
//    Keep track of the food the animals need. This means dog will need x amount of dog feed per week, etc.Different animals need different food.
//    You must create a UML class diagram and stub out your code.