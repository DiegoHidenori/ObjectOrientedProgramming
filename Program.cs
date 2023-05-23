using System.ComponentModel.Design;
using System.Xml;

namespace Week3Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int problemnumber;
            Console.Write("Hello, this is Week3. Please enter the problem number: ");
            problemnumber = Convert.ToInt32(Console.ReadLine());

            switch (problemnumber)
            {
                case 1:
                    Console.Write("You have chosen problem 1");

                    int val1, val2;
                    string input;
                    Console.Write("Enter the first whole number: ");
                    input = Console.ReadLine();
                    val1 = Convert.ToInt32(input);
                    //Another way of getting the input and converting it to a string
                    //Line 18 is equivalent to lines 14 & 15
                    //val1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the second whole number: ");
                    input = Console.ReadLine();
                    val2 = Convert.ToInt32(input);
                    if (val1 > val2)
                    {
                          Console.WriteLine(val2 + " is smaller than " + val1);
                    }
                    else
                    {
                          Console.WriteLine(val2 + " is bigger than " + val1);
                    }
                    break;
                case 2:
                    Console.WriteLine("You have chosen problem 2");

                    int num1, num2, num3;

                    Console.Write("Enter the first whole number: ");
                    input = Console.ReadLine();
                    num1 = Convert.ToInt32(input);

                    Console.Write("Enter the second whole number: ");
                    input = Console.ReadLine();
                    num2 = Convert.ToInt32(input);

                    Console.Write("Enter the third whole number: ");
                    input = Console.ReadLine();
                    num3 = Convert.ToInt32(input);

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine(num1 + " is the biggest number.");
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine(num2 + " is the biggest number.");
                    }
                    else
                    {
                        Console.WriteLine(num3 + " is the biggest number.");
                    }
                    break;
                default:
                    Console.WriteLine("Input not recognized.");
                    break;
            }
            Console.ReadKey();
        }
    }
}