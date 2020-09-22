using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lampWorking = true;
            if (lampWorking)
            {
                Console.WriteLine("Lamp is working");
            }
            else
            {
            Console.WriteLine("Lamp is not working");
            }
            bool pluggIn = true;
            if (pluggIn)
            {
                Console.WriteLine("Lamp is plugged in.");
            }
            else
            {
                Console.WriteLine("Plug in lamp.");
            }
            bool bulbBurnedOut = true;
            if (bulbBurnedOut)
            {
                Console.WriteLine("Replace Bulb.");
            }
            else
            {
                Console.WriteLine("Repair lamp.");
            }

        }
    }
}
