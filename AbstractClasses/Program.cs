using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dog Name:");
            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Age = 5 ;
            dog.Colour="Brown";

            Console.WriteLine("Name of the Dog: "+dog.Name);
            Console.WriteLine("Age of the Dog: "+dog.Age);
            Console.WriteLine("Colour of the Dog: "+dog.Colour);
            dog.Eat();
            

            Console.Write("Enter Cat Name: ");
            string catName = Console.ReadLine();
            Cat cat = new Cat();
            cat.Name = catName;
            cat.Age = 2 ;
            cat.Colour = "White";

            Console.WriteLine("Name of the Cat: "+cat.Name);
            Console.WriteLine("Age of the Cat: "+cat.Age);
            Console.WriteLine("Colour of the Cat: "+cat.Colour);
            cat.Eat();
        }
    }
    public abstract class Animal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
       

        private string colour;
        public string Colour { get { return colour; } set { colour = value; } }


        private int age;
        public int Age { get {return age; } set { age = value; } }


        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}