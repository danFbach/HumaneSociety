using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class adopter
    {
        public string adopterFirstName;
        public string adopterLastName;
        public int speciesChoice;
        public string petName;
        public string petBreed;
        public adopter(string firstNameOfAdopter, string lastNameOfAdopter, int speciesPreference, string adoptedPet, string adoptedBreed)
        {
            adopterFirstName = firstNameOfAdopter;
            adopterLastName = lastNameOfAdopter;
            speciesChoice = speciesPreference;
            petName = adoptedPet;
            petBreed = adoptedBreed;
        }
    }
}
