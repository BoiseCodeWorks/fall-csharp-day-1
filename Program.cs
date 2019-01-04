using System;
using System.Collections.Generic;

namespace hwapp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Green;
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("Hello World!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($@"
      Hello {name}");
      int age = 30;
      bool alive = true;
      if (age.Equals(21) || age > 21)
      {
        Console.WriteLine("Drink up me hardy yo-ho");
      }
      //   int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7 };
      //   for (int i = 0; i < myNumbers.Length; i++)
      //   {
      //     System.Console.WriteLine(myNumbers[i]);
      //   }

      List<string> myNumbers = new List<string>() { "1", "2" };
      myNumbers.Add("1");
      myNumbers.Add("2");
      myNumbers.Add("2");
      myNumbers.Remove("2");
      Console.WriteLine(myNumbers);
      for (int i = 0; i < myNumbers.Count; i++)
      {
        Console.WriteLine(myNumbers[i]);
      }
      foreach (string magicNumber in myNumbers)
      {
        System.Console.WriteLine(magicNumber);
      }
      myNumbers.ForEach(n =>
      {
        System.Console.WriteLine(n);
      });
      Dictionary<string, string> myDictionary = new Dictionary<string, string>();
      myDictionary.Add("name", "mark");
      System.Console.WriteLine(myDictionary["name"]);
      string[] choices = { "rock", "paper", "scissors" };
      Random random = new Random();
      int randomNumber = random.Next(0, 3);
      bool playing = true;
      while (playing)
      {

      }
    }
  }
}
