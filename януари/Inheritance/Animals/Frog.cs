﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frog : Animal
{
    public Frog(string name, int age, string gender)
        : base(name, age, gender)
    {
        // pass
    }

    public override string ProduceSound()
    {
        return "Ribbit";
    }
}
