int days = int.Parse(Console.ReadLine());
int confectionerCount = int.Parse(Console.ReadLine());
int cakesCount = int.Parse(Console.ReadLine());
int gofrettiCount = int.Parse(Console.ReadLine());
int pancakesCount = int.Parse(Console.ReadLine());


var consumablesPerConfectioner = (double)cakesCount * 45 + (double)gofrettiCount * 5.80 + (double)pancakesCount * 3.20;
var total = (confectionerCount * consumablesPerConfectioner) * days;

Console.WriteLine(total / (1 / 8));