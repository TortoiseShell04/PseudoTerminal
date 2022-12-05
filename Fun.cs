using System;
namespace App
{
    class FunIsFun
    { 
        // FUN RANDOM NUMBER GENERATOR
        Random rand = new Random();

        public void FunVal()
        {
            int fun = rand.Next(100);

            Console.WriteLine($"/>>> {fun}");

        }
    }
}
