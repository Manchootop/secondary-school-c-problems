using System;
using System.Collections.Generic;
using System.Text;

class Dog : Animal
{
    string name;
    int age;
    public Dog(string name, int age) : base(name, age)
    {
        this.name = name;
        this.age = age;
    }

    public string MakeNoise()
    {
        return "Woof!";
    }

    public string MakeTrick()
    {
        return "Hold my paw, human!";
    }

}