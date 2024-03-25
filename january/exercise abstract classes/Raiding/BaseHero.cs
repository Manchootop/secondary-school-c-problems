using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class BaseHero
{
    public string Name;
    public int Power;
    public abstract string CastAbility();

    public BaseHero(string name)
    {
        Name = name;
    }
    
}



