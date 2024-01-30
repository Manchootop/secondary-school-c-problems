using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Paladin : BaseHero
{
    public int Power = 100;
    string Name;
    public Paladin(string name) : base(name)
    {
        Name = name;
    }

    public override string CastAbility()
    {
        return $"Paladin - {this.Name} healed for {this.Power}";
    }
}
 