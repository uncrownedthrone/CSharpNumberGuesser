// DONE set variables for min and max numbers
// DONE generate randomNumber between 1 and 100
// DONE add console output messages
// DONE determine if userGuess is higher or lower than randomNumber
// DONE let user guess again


using System;

namespace CSharpNumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1.0;
      var max = 100.0;
      var playGame = false;

      Console.WriteLine("Pick a number between 1 and 100 and I'll guess it!");
      Console.WriteLine("When you're ready, type | ready | below and press Enter");
      var ready = Console.ReadLine();
      if (ready == "ready")
      {
        playGame = false;
      }
      else
      {
        Environment.Exit(0);
      }

      while (!playGame)
      {
        var compGuess = Math.Floor((min + max) / 2);
        Console.WriteLine($"Is this your number? | {compGuess}");
        Console.WriteLine("Higher? Type | higher | and press Enter");
        Console.WriteLine("Lower? Type | lower | and press Enter");
        Console.WriteLine("Did I get it? Then type | yes | and press Enter");
        var checkGuess = Console.ReadLine();
        if (checkGuess == "yes")
        {
          playGame = true;
          Console.WriteLine("I guessed it! :) Play again?");
          Console.WriteLine("Type | yes | and press Enter");
          Console.WriteLine("Type | no | and press Enter");
          var playAgain = Console.ReadLine();
          if (playAgain == "yes")
          {
            playGame = false;
            min = 1.0;
            max = 100.0;
          }
        }
        else if (checkGuess == "higher")
        {
          min = compGuess;
        }
        else if (checkGuess == "lower")
        {
          max = compGuess;
        }
      }

    }
  }
}
