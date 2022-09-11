using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.ComponentModel;
using System.Windows;

namespace ConsoleApp1
{
    class program
    {
        static void PrintEverywhere(string text_to_print, bool do_console=true)
        {
            using (StreamWriter writer = new StreamWriter("out.txt", true))
            {
                if (do_console)
                {
                    Console.WriteLine(text_to_print);
                }
                writer.WriteLine(text_to_print);
            }
        }


        public static void Main(string[] args)
        {

            StreamWriter temp = new StreamWriter("out.txt");
            temp.Close();
          
            
            
            Random rnd = new Random();

            int number1;
            int number2;
            int number3;
            int number4;
            var totalProblems = 0;
            var percentCorrect = 0d;
            int correct = 0;
            int incorrect = 0;


                while (true)
                {

                    Console.Clear();

                    number1 = rnd.Next(1, 99);
                    number2 = rnd.Next(1, 99);

                    number3 = rnd.Next(1, 9);
                    number4 = rnd.Next(1, 9);

                    int operation = rnd.Next(1, 4);
                    string operatorString;
                    int answer;
                    double sum = 0;
                    totalProblems++;

                    Console.WriteLine("\tMath Practicer:");

                    Console.WriteLine("\t-------------");



                    switch (operation)
                    {
                        case 1:
                            sum = number1 + number2;
                            operatorString = "+";
                            break;
                        case 2:
                            if (number2 > number1)
                            {
                                int temp2 = number1;
                                number1 = number2;
                                number2 = temp2;
                            }
                            sum = (number1 - number2);
                            operatorString = "-";
                            break;
                        case 3:
                            sum = number3 * number4;
                            operatorString = "*";
                            break;

                        default:
                            sum = 0;
                            operatorString = "?";
                            break;
                    }

                    if (operatorString == "*")
                    {
                        PrintEverywhere($"{number3} * {number4} = ");

                    }
                    else
                    {

                        PrintEverywhere($"{number1} { operatorString} {number2} = ");

                    }
                
                int inputAsInt;
                var input = Console.ReadLine();

                while (!int.TryParse(input, out inputAsInt))
                {
                    PrintEverywhere("Answer must be an integer. Try again: \n* If you want to Stop the game should complete the task");
                    input = Console.ReadLine();
                }
                if (inputAsInt == Math.Abs(sum))

                {
                    PrintEverywhere("Correct! \n Press the Enter to continue/type Stop to Stop;)");
                    ++correct;
                }
                else if (inputAsInt != Math.Abs(sum))
                {
                    PrintEverywhere("Sorry, the correct answer was: "  + Math.Abs(sum));
                    Console.WriteLine("Press the Enter to continue, type Stop to stop ");
                    ++incorrect;
                }
                PrintEverywhere("User answered :  " + inputAsInt, false);

                string a = Console.ReadLine();
                if (a == "Stop")
                {
                    PrintEverywhere("The end");

                    PrintEverywhere("Your correct: " + correct);
                    PrintEverywhere("Your incorrect: " + incorrect);
                    Console.WriteLine("Do you want to continue? [Y/N]");
                    string b = Console.ReadLine();

                    if (b == "Y")
                    {
                        Console.WriteLine("Okay man;)");
                    }
                    if (b == "N")
                    {
                        System.Environment.Exit(0);
                    }
                    if (b == "\n")
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
        }
    }
}   


        
  





