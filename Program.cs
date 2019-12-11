// DONE set variables for min and max numbers
// DONE generate randomNumber between 1 and 100

// TODO set variable for userGuess
// TODO determine if userGuess is higher or lower than randomNumber
// TODO let user guess again

using System;

namespace CSharpNumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var compGuess = Math.Floor((min + max) / 2);
    }
  }
}
