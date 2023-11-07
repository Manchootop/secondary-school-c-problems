var time = int.Parse(Console.ReadLine());
var day = Console.ReadLine();

if (time >= 10 && time <= 18)
{
    switch(day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            Console.WriteLine("open");
            break;
        default:
            Console.WriteLine("closed");
            break;
    }

}

else
{
    Console.WriteLine("closed");
}
    