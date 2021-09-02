using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "Amy";
    int age = 44;
    bool isFemale = true;
    

    Console.WriteLine("My name is " + firstName);
    Console.WriteLine("My age is {0}", age);
    Console.WriteLine($"I am female: {isFemale}");

    if ( age > 17)
    {
      Console.WriteLine("This person is an adult.");
    }
    else
    {
      Console.WriteLine("This person is a child.");
    }
  }
}