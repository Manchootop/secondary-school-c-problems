using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Hero
{
    private string username;
    private int level;
    public string Username { get; set; }
    public int Level { get; set; }
    public Hero(string username, int level)
    {
        this.Username = username;
        this.Level = level;
    }

    public string ToString()
    {
        return $"{this.Username} with level - {this.Level}";
    }
}
