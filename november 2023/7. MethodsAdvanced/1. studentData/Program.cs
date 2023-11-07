static void printStudentData(string name, int grade)
{
    Console.WriteLine($"{name} is studying in {grade} grade.");
}
var name = Console.ReadLine();
var grade = int.Parse(Console.ReadLine());
printStudentData(name, grade);