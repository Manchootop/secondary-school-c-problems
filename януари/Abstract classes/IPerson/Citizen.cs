﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Citizen : IPersonInterface, IIdentifiable, IBirthable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Birthdate { get; set; }
    public string Id { get; set; }
    public Citizen(string name, int age, string birthdate, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Birthdate = birthdate;
        this.Id = id;
    }
}
