namespace Candy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string candyColor = Console.ReadLine();
            string boxSize = Console.ReadLine();
            int boxCount = Convert.ToInt32(Console.ReadLine());

            double output = 0.0;
            switch (candyColor)
            {
                case "Red":
                    if (boxSize == "Small")
                    {
                        output = boxCount * 1.50;
                    }
                    else if (boxSize == "Medium")
                    {
                        output = boxCount * 2.20;
                        output *= 0.95;
                    }
                    else if (boxSize == "Large")
                    {
                        output = boxCount * 3.70;
                    }
                    if (output > 30)
                    {
                        output *= 0.90;
                    }
                    break;
                case "Blue":
                    if (boxSize == "Small")
                    {
                        output = boxCount * 1.30;
                    }
                    else if (boxSize == "Medium")
                    {
                        output = boxCount * 1.80;
                        output *= 0.95;
                    }
                    else if (boxSize == "Large")
                    {
                        output = boxCount * 2.10;
                    }
                    if (output > 30)
                    {
                        output *= 0.90;
                    }
                    break;
                case "Green":
                    if (boxSize == "Small")
                    {
                        output = boxCount * 2.50;
                    }
                    else if (boxSize == "Medium")
                    {
                        output = boxCount * 3.60;
                        output *= 0.95;
                    }
                    else if (boxSize == "Large")
                    {
                        output = boxCount * 5.20;
                        if (boxCount >= 5)
                        {
                            output *= 0.75;
                        }
                    }
                    if (output> 30)
                    {
                        output *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"You bought {boxCount} boxes of {candyColor} candy for {output:f2}lv.");
        }
    }
}