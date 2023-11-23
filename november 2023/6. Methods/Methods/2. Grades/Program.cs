static void PrintInWords(int grade)
{
    if (grade >= 2.00 && grade <= 2.99)
        Console.WriteLine("Poor");
    else if (grade > 2.99 && grade <= 3.49)
        Console.WriteLine("Poor");
    else if (grade > 3.99 && grade <= 4.49)
        Console.WriteLine("Poor");
    else if (grade > 4.99 && grade <= 5.49)
        Console.WriteLine("Poor");
    else
        Console.WriteLine("excellent");

}

int grade = int.Parse(Console.ReadLine());

PrintInWords(grade);