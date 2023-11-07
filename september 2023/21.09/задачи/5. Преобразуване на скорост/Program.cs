

float distance_in_metres = float.Parse(Console.ReadLine());

int hours = int.Parse(Console.ReadLine());

int minutes = int.Parse(Console.ReadLine());

int seconds = int.Parse(Console.ReadLine());

double kilometers_to_miles_per_hour = 1.609;
int meters_in_kilometers = 1000;

// solution

float meters_per_second = distance_in_metres / (hours * 3600 + minutes * 60 + seconds);

//float kilometers_per_hour = (distance_in_metres / meters_in_kilometers) / (hours + minutes / 60 + seconds / 3600);

float kilometers_per_hour = meters_per_second * (float)3.6;


float miles_per_hour = kilometers_per_hour / (float)kilometers_to_miles_per_hour;
Console.WriteLine($"meters per second = {meters_per_second:f6}; kilometers per hour = {kilometers_per_hour:f6}; miles_per_hour = {miles_per_hour:f6}");