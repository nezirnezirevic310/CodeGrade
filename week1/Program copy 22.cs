﻿using System;

namespace DiceRoll
{
    class Program
    {
        static void Main()
        {
            Random random = new Random(1);

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine(random.Next(1, 7));
            }
        }
    }
}
