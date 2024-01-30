public class Dog : Animal
{
    public Dog(string name, int age, string gender)
        : base(name, age, gender)
    {
     // pass 
    }
    public override string ProduceSound()
    {
        return "Woof!";
    }
}