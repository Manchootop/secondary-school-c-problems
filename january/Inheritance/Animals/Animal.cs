﻿public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    public string Gender
    {
        get { return gender; }
    }

    public virtual string ProduceSound()
    {
        return "";
    }
}

