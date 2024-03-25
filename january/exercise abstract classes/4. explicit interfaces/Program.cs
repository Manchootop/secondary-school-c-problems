string command = Console.ReadLine();

while (command != "End")
{
    string[] array = command.Split(" ");
    string name = array[0];
    string country = array[1];
    string age = array[2];
    IPerson c = new Citizen(name, country, age);
    IResident c1 = new Citizen(name, country, age);

    Console.WriteLine(c.GetName());
    Console.WriteLine(c1.GetName()); 
    command = Console.ReadLine();
}