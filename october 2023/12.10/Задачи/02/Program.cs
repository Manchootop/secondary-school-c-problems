var shape = Console.ReadLine();
var attribute = double.Parse(Console.ReadLine());
if (shape == "square")
    Console.WriteLine($"{attribute * attribute:f2}");

if (shape == "rectangle")
{
    var otherSide = double.Parse(Console.ReadLine());
    Console.WriteLine($"{attribute * otherSide:f2}");

}
if (shape == "circle")
    Console.WriteLine($"{attribute * attribute * Math.PI:f2}");

if (shape == "triangle")
{
    var height = double.Parse(Console.ReadLine());
    Console.WriteLine($"{attribute * height / 2:f2}");

}