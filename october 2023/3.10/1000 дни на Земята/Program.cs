// Въвеждане на рождена дата от потребителя
Console.Write("Въведете рождена дата (dd-MM-yyyy): ");
string birthdayStr = Console.ReadLine();

DateTime birthday = DateTime.ParseExact(birthdayStr, "dd-MM-yyyy", null);

DateTime anniversary = birthday.AddDays(999);

string anniversaryStr = anniversary.ToString("dd-MM-yyyy");

Console.WriteLine("Дата след 1000 дни от рождената дата: " + anniversaryStr);
