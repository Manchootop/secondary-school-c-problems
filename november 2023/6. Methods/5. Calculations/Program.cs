static void Calculations(string opt, int num1, int num2)
{
    if (opt == "substract")
        Console.WriteLine(num1 - num2);
    else if (opt == "add")
        Console.WriteLine(num1 + num2);
    else if (opt == "multiply")
        Console.WriteLine(num1 * num2);
    else if (opt == "divide" && num2 != 0)
        Console.WriteLine(num1 / num2);
    else
        Console.WriteLine("error");
}
string opt = Console.ReadLine();
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Calculations(opt, num1, num2);