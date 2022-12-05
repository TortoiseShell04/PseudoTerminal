using System;
namespace PseudoTerminal
{
    class Terminal
    {
        // CLASS REFRENCES
        static readonly Timer time = new();
        static readonly ExitApp exit = new();
        static readonly LowerCase low = new();
        static readonly Help help = new();
        static readonly RockPaperScissors rock = new();
        static readonly StringDissect stringsAct= new();
        static readonly FunIsFun fun = new();

        // VARIABLES FOR STRING INPUT AND TITLE SCREEN
        static string command = "Command goes here";
        static bool hasRan = false;

        // TERMINAL METHOD
        public static void TerminalApp()
        {
            if (!hasRan)
            {
                Console.WriteLine("/>>> Alpha terminal 1.0.1");
                hasRan = true;
            }
            
            // MAIN LOOP OF THE PROGRAM
            while (true)
            {
                Console.Write("/>>> ");
                command = Console.ReadLine();

                 switch (command)
                 {
                    case "string":
                        stringsAct.stringOperation();
                        break;
                    case "fun":
                        fun.FunVal();
                        break;
                    case "exit":
                        exit.ExitsApp();
                        break;
                    case "rock":
                        rock.RockP();
                        break;
                    case "help":
                        help.help();
                        break;
                    case "timer":
                        time.Time();
                        break;
                    case "lower":
                        low.Lower();
                        break;
                    default:
                        break;    
                }
                
            }
        }
    }
}
