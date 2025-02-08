using System;

// Base class representing a general Animal
class Animal
{
    public string Name { get; set; }  // Stores the name of the animal
    public int Age { get; set; }  // Stores the age of the animal

    // Virtual method to represent making a sound (to be overridden in subclasses)
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Dog class inherits from Animal
class Dog : Animal
{
    // Overriding MakeSound() to provide specific behavior for Dog
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

// Cat class inherits from Animal
class Cat : Animal
{
    // Overriding MakeSound() to provide specific behavior for Cat
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

// Bird class inherits from Animal
class Bird : Animal
{
    // Overriding MakeSound() to provide specific behavior for Bird
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps.");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating an array of Animal type storing different subclasses
        Animal[] animals = {
            new Dog { Name = "Buddy", Age = 3 },
            new Cat { Name = "Whiskers", Age = 2 },
            new Bird { Name = "Tweety", Age = 1 }
        };

        // Loop through each animal and call the MakeSound() method
        foreach (var animal in animals)
        {
            Console.WriteLine($"Animal: {animal.Name}, Age: {animal.Age}");
            animal.MakeSound();  // Polymorphism in action
            Console.WriteLine();
        }
    }
}
