using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TalentAtm
{
    internal class Utility
    {
        private static CultureInfo _enculture = new CultureInfo("en-US");


        public static decimal GetDecimalInputAmt(string input)
        {
           bool valid = false;

            string rawInput;

            decimal amount = 0;

            
            while (!valid)
            {
                rawInput = GetRawInput(input);
                valid = decimal.TryParse(rawInput, out amount);
                if (!valid)
                    switch (LangChoice._choice)
                    {
                        case 1:
                            PrintMessage("Invalid input. Try again.", false);
                            break;
                        case 2:
                            PrintMessage("I he itinyere ekwesiri ro. Megharia ya.", false);
                            break;
                        case 3:
                            PrintMessage("your input  no dey. Try am again.", false);
                            break;
                        default:
                            PrintMessage("Invalid input. Try again.", false);
                            break;


                    }
                
            }

            return amount;
        }

        
        public static  Int64 GetIntInputAmount(string input)
        {
            bool valid = false;

            string rawInput;

            Int64 amount = 0;

            // Get user's input input type is valid
            while (!valid)
            {
                rawInput = GetRawInput(input);
                valid = Int64.TryParse(rawInput, out amount);
                if (!valid)
                    switch (LangChoice._choice)
                    {
                        case 1:
                            PrintMessage("Invalid input. Try again.", false);
                            break;
                        case 2:
                            PrintMessage("I he itinyere ekwesiri ro. Megharia ya.", false);
                            break;
                        case 3:
                            PrintMessage("your input  no dey. Try am again.", false);
                            break;
                        default:
                            PrintMessage("Invalid input. Try again.", false);
                            break;


                    }
               
            }

            return amount;

        }

        public static string GetRawInput(string message)
        {
            switch (LangChoice._choice)
            {
                case 1:
                    Utility.PrintColorMessage(ConsoleColor.Cyan, $" please enter {message}: ");
                    break;
                case 2:
                    Utility.PrintColorMessage(ConsoleColor.Cyan, $" Biko tinye {message}: ");
                    break;
                case 3:
                    Utility.PrintColorMessage(ConsoleColor.Cyan, $" you go enter  {message}: ");
                    break;
                default:
                    Utility.PrintColorMessage(ConsoleColor.Cyan, $" please enter {message}: ");
                    break;


            }
           
            return Console.ReadLine();
        }



        public static void printDotAnimation(int timer = 10)
        {
            for (var x = 0; x < timer; x++)
            {
                PrintColorMessage(ConsoleColor.Yellow, ".");

                Thread.Sleep(100);
            }
            Console.WriteLine();
        }

        public static string FormatAmount(decimal amt)
        {
            return String.Format(_enculture, "{0:C2}", amt);
        }

        public static void PrintMessage(string msg, bool success)
        {
            if (success)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            PrintColorMessage(ConsoleColor.Yellow, msg);

            Console.ResetColor();
            switch (LangChoice._choice)
            {
                case 1:
                    PrintColorMessage(ConsoleColor.Cyan, "Press any key to continue");
                    Console.ReadKey();
                    break;
                case 2:
                    PrintColorMessage(ConsoleColor.Cyan, "Pia key obula ka inwe ga niiru");
                    Console.ReadKey();
                    break;
                case 3:
                    PrintColorMessage(ConsoleColor.Cyan, "You fit press any key make u continue");
                    Console.ReadKey();
                    break;
                default:
                    PrintColorMessage(ConsoleColor.Cyan, "Press any key to continue");
                    Console.ReadKey();
                    break;


            }

        }

            // print color message
        public  static void PrintColorMessage(ConsoleColor color, string message)
        {
            
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
