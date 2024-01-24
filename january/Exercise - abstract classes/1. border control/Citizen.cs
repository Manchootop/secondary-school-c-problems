using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Citizen : IPerson
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Age { get; set; }

    public Citizen(string name, string id, string age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public void CheckIdentity(decimal id, decimal fakeId)
    {
        while (true)
        {
            if (id.Equals(fakeId))
            {
                Console.WriteLine(id);
                break;
            }
            else
                id /= 10;
        }

    }
}
