char[] separators = { ',', ';', ':', '.', '!', '(', ')', '\\', '\'', '\"', '/', '[', ']', ' ' };

List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

List<string> upperCase = new List<string>();
List<string> lowerCase = new List<string>();
List<string> mixedCase = new List<string>();

foreach (string word in text)
{
    bool upper = false;
    bool lower = false;

    foreach(char c in word)
    {
        if (char.IsLower(c))
        {
            lower = true;
        }
        else if (char.IsUpper(c))
        {
            upper = true;
        }
    }

    if(upper && lower)
    {
        mixedCase.Add(word);
    }

    else if (upper)
    {
        upperCase.Add(word);
    }

    else if (lower)
    {
        lowerCase.Add(word);
    }
}

Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");