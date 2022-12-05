using System;

namespace PseudoTerminal
{
    public class LowerCase
    {
        public void Lower()
        {
          string text = "Text goes here";
          Console.Write("/>>> Enter text to convert to lowercase: ");
          text = Console.ReadLine();
          text = text.ToLower();
        
          Console.WriteLine($"/>>> {text}");
        }
    }
}