using System;

namespace variables2
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberOfCupsOfCoffee = 3;
      var name = "Justin Sorensen";
      var today = DateTime.Now;

      Console.WriteLine($"Hi! My name is {name} and I drank {numberOfCupsOfCoffee} on {today}.");

      Console.WriteLine("I'm ready to do some math.");

      Console.WriteLine("Please enter a number.");

      var operand1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Please enter another number.");

      var operand2 = double.Parse(Console.ReadLine());

      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;

      Console.WriteLine($"{operand1} plus {operand2} equals {sum}.");
      Console.WriteLine($"{operand1} minus {operand2} equals {difference}.");
      Console.WriteLine($"{operand1} divided by {operand2} equals {quotient}.");
      Console.WriteLine($"{operand1} multiplied by {operand2} equals {product}.");
    }
  }
}
