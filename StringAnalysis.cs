using System;
namespace App
{
    class StringDissect
    {
        // USER TEXT STRING 
        string text = "Text goes here";
        public void stringOperation()
        {
            // USER INPUT
            Console.Write("/>>> Enter text to analyse: ");
            text = Console.ReadLine();
            int length = text.Length;

            // STRING FOR LOOP TO CHECK THE STRING 
            for (int i = 0; i < length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' ||
                    text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || text[i] == 'U' )
                { 
                    Console.WriteLine($"/>>> {text[i]} is a vowel"); 
                }

                else if (text[i] == ' ')
                {
                    // DO NOTHING
                }
                else 
                {
                    Console.WriteLine($"/>>> {text[i]} is a consonant");
                }
            }

        }
    }
}