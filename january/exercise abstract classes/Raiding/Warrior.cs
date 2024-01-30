using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Warrior : BaseHero
{
    public int Power = 100;
    string Name;
    public Warrior(string name) : base(name)
    {
        Name = name;
    }

    public override string CastAbility()
    {
        return $"Warrior - {this.Name} hit for {this.Power}";
    }
}
