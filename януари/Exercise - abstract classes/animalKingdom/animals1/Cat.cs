using System;
using System.Collections.Generic;
using System.Text;

class Cat : Animal
{
    string name;
    int age;
    public Cat(string name, int age) : base(name, age)
    {
        this.name = name;
        this.age = age;
    }

    public string MakeNoise()
    {
        return "Meow!";
    }

    public string MakeTrick()
    {
        return "No trick for you! I'm too lazy!";
    }


}