string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string id = Console.ReadLine();
string birthdate = Console.ReadLine();


IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
IBirthable ibirtable = new Citizen(name, age, id, birthdate);

Console.WriteLine(identifiable.Id);
Console.WriteLine(ibirtable.Birthdate);
