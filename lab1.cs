using System;

class Program
{
  static void Syntax(string[] args)
  {
    Console.WriteLine("How many numbers do you want to enter?");
    if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
    {
      Console.WriteLine("Invalid input. Please restart the program and enter a valid positive integer.");
      return; // Exit if the input is not a valid positive integer
    }

    int[] numbers = new int[count];
    int sum = 0;
    int max = int.MinValue;

    Console.WriteLine($"Please enter {count} integers:");

    for (int i = 0; i < count; i++)
    {
      Console.Write($"Number {i + 1}: ");
      if (int.TryParse(Console.ReadLine(), out int number))
      {
        numbers[i] = number;
        sum += number;
        if (number > max)
        {
          max = number;
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter an integer.");
        i--; // Decrement i to retry the current iteration
      }
    }

    double average = (double)sum / count;

    Console.WriteLine($"Sum of all numbers: {sum}");
    Console.WriteLine($"Average of the numbers: {average}");
    Console.WriteLine($"Maximum number: {max}");
  }
}
