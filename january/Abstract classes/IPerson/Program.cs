﻿string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

IPersonInterface person = new Citizen(name, age);

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
