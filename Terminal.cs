using System;
namespace PseudoTerminal
{
    class Terminal
    {
        // CLASS REFRENCES
        static Timer time = new Timer();
        static LowerCase low = new LowerCase();
        static Help help = new Help();
        static RockPaperScissors rock = new RockPaperScissors();
        static StringDissect stringsAct= new StringDissect();
        static FunIsFun fun = new FunIsFun();

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

                if (command == "string")
                {
                    stringsAct.stringOperation();
                }
                if (command == "fun")
                {
                    fun.FunVal();
                    
                }
                if (command == "exit")
                {
                    break;
                }
                if (command == "rock")
                {
                    rock.RockP();
                }
                if (command == "help")
                {
                    help.help();
                }
                if (command == "timer")
                {
                    time.Time();
                }
                if (command == "lower")
                {
                    low.Lower();
                }
            }
        }
    }
}
