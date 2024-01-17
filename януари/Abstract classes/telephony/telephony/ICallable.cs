using System;
using System.Collections.Generic;
using System.Text;

public interface ICallable
{
    public string Number { get; set; }
    public string Calling(string number)
    {
        string answer = "";
        try
        {
            int numberWithDigits = int.Parse(number);
            answer += $"Calling {numberWithDigits}";
        }
        catch (Exception)
        {
            return "Invalid number!";
        }

        return answer;
    }
}