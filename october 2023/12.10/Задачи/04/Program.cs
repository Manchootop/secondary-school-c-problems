var hours = int.Parse(Console.ReadLine());
var minutes = double.Parse(Console.ReadLine());
minutes += 15;

if (minutes >= 60)
{
    hours += 1;
    minutes -= 60;
    if (hours >= 24)
        hours -= 24;
}

Console.WriteLine($"{hours}:{minutes:00}");