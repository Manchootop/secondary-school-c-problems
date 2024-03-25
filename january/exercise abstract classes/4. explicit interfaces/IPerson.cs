using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPerson
{
    public string Name { get; set; }
    public string Age { get; set; }

    public string GetName()
    {
        return "";
    }
}