using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPerson
{
    public string Name { get; set; }
    public string Id { get; set; }
    public void CheckIdentity(decimal Id, decimal fakeId)
    {

    }
}