double num = double.Parse(Console.ReadLine());
string unit = Console.ReadLine();
string unitToConvertTo = Console.ReadLine();
double result = 0;
if (unit == "mm")
{
    switch (unitToConvertTo)
    {
        case "m": result = num / 1000;
           break;
        case "cm": result = num / 100;
            break;
    }
}
else if (unit == "cm")
{
    switch (unitToConvertTo)
    {
        case "m":
            result = num / 100;
            break;
        case "mm":
            result = num * 10;
            break;
    }
}
else
{
    switch (unitToConvertTo)
    {
        case "mm":
            result = num * 1000;
            break;
        case "cm":
            result = num * 100;
            break;
    }
}

Console.WriteLine($"{result:F3}");
