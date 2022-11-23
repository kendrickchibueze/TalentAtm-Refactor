using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    internal class LangChoice
    {
        
        public  static int _choice;
        public static string _option;
        
        

        public static void ChooseLang()
        {
            Utility.PrintColorMessage(ConsoleColor.Yellow, "***** Welcome to the Talent Bank ******");

            Utility.PrintColorMessage(ConsoleColor.Cyan, "\nSelect your preferred language:");

            Utility.PrintColorMessage(ConsoleColor.Yellow, "\n1 [English], 2 [igbo], 3 [pidgin-English]");

            Utility.PrintColorMessage(ConsoleColor.Cyan, "\nPlease enter an option:");

            _choice = int.Parse(Console.ReadLine());
            

            switch (_choice)
            {
                case 1:
                    Screen.ShowMenuOne();
                    break;
                case 2:
                    ShowMenuIgbo();
                    break;
                case 3:
                    ShowMenupidgin();
                    break;
                default:
                    Screen.ShowMenuOne(); ;
                    break;


            }
        }

        public static string morechoice(string _option)
        {
            switch (LangChoice._choice)
            {
                case 1:
                    _option = "your option";

                    break;
                case 2:
                    _option = "optionu gi";

                    break;
                case 3:
                    _option = "your option";
                    break;
                default:
                    _option = "your option";

                    break;


            }
            return _option;

        }

        public static void ShowMenuIgbo()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| TalentBank ATM Menu    |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 1. Tinye ATM cardi gi  |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 2. uzo opupu           |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ------------------------");
        }

        public static void ShowMenuIgboSecureMenu()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ---------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| TalentBank ATM Secure Menu|");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                           |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 1. ajuju itule ego        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 2. nkwunye ego            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 3. ndoro ego              |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 4. Nyefee ego             |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 5. ihe i mere na bank     |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 6. opupu                  |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                           |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ---------------------------");
        }

        public static void ShowMenupidgin()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| TalentBank ATM Menu    |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 1. abeg put your card  |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 2. commot              |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ------------------------");
        }

        public static void ShowMenupidginSecure()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow, " -----------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| TalentBank ATM Secure Menu  |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                             |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 1. u wan check balance      |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 2. u fit deposit            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 3. collect money            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 4. u fit transfer money     |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 5. u go see ur transactions |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "| 6. commot                   |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, "|                             |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ------------------------------");
        }
    }

  
}
