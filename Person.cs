using System;
class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy Constructor
    public Person(Person existingPerson)
    {
        this.name = existingPerson.name;
        this.age = existingPerson.age;
    }

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}