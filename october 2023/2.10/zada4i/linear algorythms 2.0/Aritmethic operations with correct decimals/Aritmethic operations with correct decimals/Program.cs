namespace Aritmethic_operations_with_correct_decimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_numerator = Convert.ToInt32(Console.ReadLine());
            int first_divisor = Convert.ToInt32(Console.ReadLine());
            int second_numerator = Convert.ToInt32(Console.ReadLine());
            int second_divisor = Convert.ToInt32(Console.ReadLine());

            int divisor = 0, multiplication_numerator =0, multiplication_divisor=0;
            if(first_divisor%second_divisor == 0)
            {
                divisor = first_divisor;
                second_numerator = second_numerator * (first_divisor / second_divisor);
            }
            else if (second_divisor % first_divisor == 0)
            {
                divisor = second_divisor;
                first_numerator = first_numerator * (second_divisor / first_divisor);
            }
            else
            {
                divisor = first_divisor * second_divisor;
                first_numerator = first_numerator * (divisor / first_divisor);
                second_numerator = second_numerator * (divisor / second_divisor);
            }
            multiplication_numerator = first_numerator * second_numerator;
            multiplication_divisor = divisor * divisor;
            Console.WriteLine($"{first_numerator+second_numerator}/{divisor}");
            Console.WriteLine($"{first_numerator-second_numerator}/{divisor}");
            Console.WriteLine($"{multiplication_numerator}/{multiplication_divisor}");
        }
    }
}