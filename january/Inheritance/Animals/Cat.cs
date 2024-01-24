public class Cat : Animal
{
    public Cat(string name, int age, string gender)
        : base(name, age, gender)
    {
        // pass
    }
    public override string ProduceSound()
    {
        return "Meow meow";
    }
}