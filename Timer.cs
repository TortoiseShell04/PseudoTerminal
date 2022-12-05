using System;
namespace PseudoTerminal
{
    class Timer 
    {
        public void Time()
        {
            int timer = 0;
            Console.Write($"/>>> Enter a time to countdown from: ");
            timer = Convert.ToInt32(Console.ReadLine());
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);

            while (timer >= 0)
            {
                TimeSpan t2 = DateTime.UtcNow - new DateTime(1970, 1, 1);
                
                if (t2.Seconds > t.Seconds)
                {
                    Console.WriteLine($"/>>> {timer}");
                    timer--;
                    t = t2; 

                }

            }
            
        }
    }
}