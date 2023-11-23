static void GetMax(int num1, int num2)
{
    if (num1 > num2)
        Console.WriteLine(num1);
    else
        Console.WriteLine(num2);
}
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
GetMax(num1, num2);