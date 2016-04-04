using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class adopter : people
    {
        public string adopterFirstName;
        public string adopterLastName;
        public int speciesChoice;
        public adopter(string firstNameOfAdopter, string lastNameOfAdopter, int speciesPreference)
        {
            adopterFirstName = firstNameOfAdopter;
            adopterLastName = lastNameOfAdopter;
            speciesChoice = speciesPreference;
        }
    }
}
