using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
        public int age { get; set; }
        public string ownerName { get; set; }

        public bool isVaccinated { get; set; }


        public Pet(string name, string type, int age, string ownerName, bool isVaccinated) {
            this.name = name;
            this.type = type;
            this.age = age;
            this.ownerName = ownerName;
            this.isVaccinated = isVaccinated;
        }
        public string MyPetInfo()
        {
            int years = age / 12;
            int months = years % 60;
            string isVaccinatedStr = "";
            if (isVaccinated == false)
            {
                isVaccinatedStr = "vaccinated";
            }
            else
            {
                isVaccinatedStr = "unvaccinated";
            }

            string str = $"{name} – {type}, {years}y {months}, {ownerName}, {isVaccinatedStr}";
            return str;
        }

        public string CalcDiff(Pet Pet1, Pet Pet2)
        {
            if (Pet1.type == Pet2.type)
            {

                string difference = $"Diff: {Math.Abs(Pet1.age - Pet2.age)}";
                return difference;
            }

            else
            {
                return "Pets not of the same type";
            }
        }
        public string AverageAgeOfSameOwnerPets (Pet Pet1, Pet Pet2)
        {
            if (Pet1.ownerName == Pet2.ownerName)
            {
                int averageAge = (Pet1.age * Pet2.age) / 2;
                return $"Average age of {Pet1.ownerName}'s pets – {averageAge} months";

            }
            return "Pets not of same owner";
        }
    }
