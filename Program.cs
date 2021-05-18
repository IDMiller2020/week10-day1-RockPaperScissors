using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      string input = string.Empty;
      Console.WriteLine("Would you like to play Rock Paper Scissors? (y or n):");
      char choice = Console.ReadKey().KeyChar;
      Console.WriteLine("");
      if (choice == 'y')
      {
        Game currentGame = new Game();
        Console.Clear();
        Console.WriteLine("Great!");
        Console.WriteLine("Enter your choice (r, p, or s):");
        char playerChoice = Console.ReadKey().KeyChar;
        currentGame.Winner(playerChoice);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Ok, maybe next time.");
      }
    }
  }
}
