﻿using System;

namespace OperacoesComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);
            

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();

            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();

            string s5 = d1.ToString();
            string s6 = d1.ToString("yyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyy-MM-dd HH:mm:ss.fff");


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine();

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d3 = d2.AddHours(2);
            DateTime d4 = d2.AddMinutes(3);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime d5 = DateTime.Now;
            DateTime d6 = d5.AddDays(7);

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine();

            DateTime d7 = new DateTime(2000, 10, 15);
            DateTime d8 = new DateTime(2000, 10, 18);

            TimeSpan t = d8.Subtract(d7);
            Console.WriteLine(t);

        }
    }
}
