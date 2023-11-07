var pages = double.Parse(Console.ReadLine());
var pagesPerHour = double.Parse(Console.ReadLine());
var period = double.Parse(Console.ReadLine());

var timeReq = pages / pagesPerHour;
var estimatedTime = timeReq / period;
Console.WriteLine($"Estimated = {estimatedTime:f1}");