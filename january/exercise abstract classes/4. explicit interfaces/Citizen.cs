using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Citizen : IResident, IPerson
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Age { get; set; }
    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {Name}";
    }
    string IPerson.GetName()
    {
        return Name;

    }
    public Citizen(string name, string country, string age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }
}