using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public interface IBrowsable
{
    public string Website { get; set; }

	public string Browse(string Website)
    {
		string answer = "Invalid URL!";
        if (Website.All(Char.IsLetter) == true)
        {
            answer = $"Browsing: {Website}";
        }
        return answer;
}