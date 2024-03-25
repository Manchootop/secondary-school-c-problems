using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Robot : IPerson
{
    public string Model { get; set; }
    public string Id { get; set; }
    public string Name;
    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
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