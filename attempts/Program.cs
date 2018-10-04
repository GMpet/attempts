using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attempts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Random rand = new Random();
                    Console.WriteLine("What is the chance? (1/x)");
                    var input = Console.ReadLine();
                    var input2 = int.Parse(input);
                    if (input2 > 0)
                    {
                        var randomnumber = 0;
                        var attempts = 0;
                        while (true)
                        {
                            randomnumber = rand.Next(input2);
                            attempts++;
                            if (randomnumber == 1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine($"After {attempts} attempts you finally got your mount.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input is not a number");
                }
            }
        }
    }
}
