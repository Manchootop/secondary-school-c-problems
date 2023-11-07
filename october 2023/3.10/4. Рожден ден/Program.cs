var rent = double.Parse(Console.ReadLine());

var cake = rent * 0.2;
var drinks = cake * 0.55;
var animator = rent / (1/3);

var budgetReq = cake + drinks + animator;

Console.WriteLine(budgetReq);

