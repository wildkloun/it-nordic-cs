﻿using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            ReminderItem p1 = new ReminderItem(DateTimeOffset.Parse("29-03-2019"), "Доброе утро");
            p1.WriteProperties();

            Console.WriteLine();

            ReminderItem p2 = new ReminderItem(DateTimeOffset.Parse("18-06-2019 23:34"), "Позвонить в 8");
            p2.WriteProperties();

            Console.ReadKey();
        }
    }
}
