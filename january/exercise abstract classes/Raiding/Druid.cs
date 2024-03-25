using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Druid : BaseHero
{
    public int Power = 80;
    string Name;
    public Druid(string name) : base(name)
    {
        Name = name;
    }

    public override string CastAbility()
    {
        return $"Druid - {this.Name} healed for {this.Power}";
    }
}