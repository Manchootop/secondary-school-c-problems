using System;

namespace animals1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat kitten = new Cat("maria", 4);
            Dog doggie = new Dog("fifi", 3);

            Console.WriteLine("Cat: ");
            Console.WriteLine(kitten.MakeNoise());
            Console.WriteLine(kitten.MakeTrick()); 

            Console.WriteLine("Dog: ");
            Console.WriteLine(doggie.MakeNoise());
            Console.WriteLine(doggie.MakeTrick()); 


        }
    }
}
