using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    //REVIEW Explain lines 8 and 9.
    //REVIEW When do we use private set?
    private char ComputerChoice { get; set; }
    private int Number { get; set; }
    public void Winner(char playerChoice)
    {
      System.Console.WriteLine("");
      if (playerChoice == 'r' && ComputerChoice == 'p')
      {
        System.Console.Write("Computer chose Paper.  You lose!");
      }
      else if (playerChoice == 'r' && ComputerChoice == 's')
      {
        System.Console.Write("Computer chose Scissors.  You win!");
      }
      else if (playerChoice == 'p' && ComputerChoice == 'r')
      {
        System.Console.Write("Computer chose Rock.  You win!");
      }
      else if (playerChoice == 'p' && ComputerChoice == 's')
      {
        System.Console.Write("Computer chose Scissors.  You lose!");
      }
      else if (playerChoice == 's' && ComputerChoice == 'r')
      {
        System.Console.Write("Computer chose Rock.  You lose!");
      }
      else if (playerChoice == 's' && ComputerChoice == 'p')
      {
        System.Console.Write("Computer chose Paper.  You win!");
      }
      else
      {
        System.Console.Write("Tie Game!");
      }
    }
    public Game()
    {
      Random rnd = new Random();
      Number = rnd.Next(1, 4);
      if (Number == 1)
      {
        ComputerChoice = 'r';
      }
      else if (Number == 2)
      {
        ComputerChoice = 'p';
      }
      else
      {
        ComputerChoice = 's';
      }
    }
  }
}