var MINPASSLENGTH = 6;
var MAXPASSLENGTH = 10;
var MINDIGITSINPASS = 2;

bool isPasswordValid = true;
string pass = Console.ReadLine();

for (int i = 0; i < pass.Length; i++)
{
    char ch = pass[i];
    if (Char.IsDigit(ch))
        MINDIGITSINPASS -= 1;
    else if (Char.IsLetter(ch))
        continue;
    else
    {
        isPasswordValid = false;
        break;
    }
}


if (pass.Length < MINPASSLENGTH || pass.Length > MAXPASSLENGTH)
{
    Console.WriteLine("Password must be between 6 and 10 characters ");
}
if (MINDIGITSINPASS > 0)
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (isPasswordValid == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (pass.Length >= MINPASSLENGTH && pass.Length <= MAXPASSLENGTH && MINDIGITSINPASS <= 0 && isPasswordValid == true)
    Console.WriteLine("Password is valid");
