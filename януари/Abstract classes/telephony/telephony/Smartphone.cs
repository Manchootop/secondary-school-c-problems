using System;
using System.Collections.Generic;
using System.Text;

class Smartphone : ICallable, IBrowsable
{
    public string Website { get; set; }
    public string Number { get; set; }
     
    public Smartphone(string website, string number)
    {
        this.Website = website;
        this.Number = number;
    }

 

}