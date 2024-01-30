public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        while (true)
        {
            string type = Console.ReadLine();
            if (type == "Beast!")
                break;

            string[] animalInfo = Console.ReadLine().Split();

            string name = animalInfo[0];
            int age = int.Parse(animalInfo[1]);
            string gender = animalInfo[2];

            Animal animal = null;

            if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (type == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }

            if (animal != null)
            {
                animals.Add(animal);
            }
        }

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            Console.WriteLine(animal.ProduceSound());
        }
    }
}