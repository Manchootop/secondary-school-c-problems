using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Citizen : IPersonInterface
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}
