List<string> names = Console.ReadLine().Split().ToList();

names.Reverse();


Console.WriteLine(String.Join("; ", names));