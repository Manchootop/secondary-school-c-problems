using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rogue : BaseHero
{
    public int Power = 80;
    string Name;
    public Rogue(string name) : base(name)
    {
        Name = name;
    }

    public override string CastAbility()
    {
        return $"Rogue - {this.Name} hit for {this.Power}";
    }
}
