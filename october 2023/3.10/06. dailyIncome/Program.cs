var workingDays = int.Parse(Console.ReadLine());
var dailyIncome = double.Parse(Console.ReadLine());
var LEV_PER_DOLAR = double.Parse(Console.ReadLine());

var monthlyPayment = workingDays * dailyIncome;
Console.WriteLine(monthlyPayment);
var taxesPercentage = 25 / 100;
var yearlyPaymentAfterBonusesAndTaxes = monthlyPayment * 12 + monthlyPayment * 2.5;
yearlyPaymentAfterBonusesAndTaxes /=  taxesPercentage;
Console.WriteLine(yearlyPaymentAfterBonusesAndTaxes * LEV_PER_DOLAR / 365);

