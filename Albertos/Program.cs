using System;

public class Albertos
{
    public static void Main(string[] args)
    {
        string name,location,education;
        
        Console.Write("WHAT IS YOUR NAME?: ");
        name= Console.ReadLine();
        Console.WriteLine("Hi my name is "+ name);
        Console.ReadKey();
       
        Console.Write("WHERE ARE YOU FROM?: ");
        location= Console.ReadLine();
        Console.WriteLine("I am from "+location);
        Console.ReadKey();
        
        Console.Write("WHERE YOU STUDY?: ");
        education= Console.ReadLine();
        Console.WriteLine("I STUDY FROM "+ education);
        Console.ReadKey();

    }
}