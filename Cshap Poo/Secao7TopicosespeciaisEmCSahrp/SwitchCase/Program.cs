﻿using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Wesnesday";
                    break;

                case 5:
                    day = "Thusday";
                    break;

                case 7:
                    day = "Friday";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine($"Day: {day}");
        }
    }
}
