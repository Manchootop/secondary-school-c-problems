var depositSum = double.Parse(Console.ReadLine());
var period = double.Parse(Console.ReadLine());
var percentage = double.Parse(Console.ReadLine());

Console.WriteLine(depositSum + period * ((depositSum * percentage / 100) / 12));


