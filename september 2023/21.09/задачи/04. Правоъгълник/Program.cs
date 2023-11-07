double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());


double perimeter = (a + b) * 2;
double square = a * b;

double diagonal = Math.Sqrt(a * a + b * b);

Console.WriteLine($"perimeter = {perimeter}; square = {square}; diagonal = {diagonal}");

