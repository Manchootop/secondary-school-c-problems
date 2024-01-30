int n = int.Parse(Console.ReadLine());
int teamPower = 0;
string[] castAbilities = new string[n];

// add allies to team
for (int i = 0; i < n; i++)
{
    // get name and type from input
    string name = Console.ReadLine();
    string type = Console.ReadLine();

    // define hero type
    switch (type)
    {
        case "Paladin":

            Paladin paladin = new Paladin(name);
            teamPower += paladin.Power;
            castAbilities[i] = paladin.CastAbility();
            break;
        case "Druid":
            Druid druid = new Druid(name);
            teamPower += druid.Power;
            castAbilities[i] = druid.CastAbility();
            break;
        case "Rogue":
            Rogue rogue = new Rogue(name);
            teamPower += rogue.Power;
            castAbilities[i] = rogue.CastAbility();
            break;
        case "Warrior":
            Warrior warrior = new Warrior(name);
            teamPower += warrior.Power;
            castAbilities[i] = warrior.CastAbility();
            break;
    }
}


// get boss power 
int bossPower = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join('\n', castAbilities));


// victory or defeat
if (teamPower - bossPower >= 0)
    Console.WriteLine("Victory!");
else
    Console.WriteLine("Defeat...");




