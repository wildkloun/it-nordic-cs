﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }

        public TimeSpan TimeToAlarm { get { return AlarmDate.Subtract(DateTimeOffset.Now); } }

        public bool IsOutdated { get { return AlarmDate <= DateTimeOffset.Now; } }

        public virtual void WriteProperties()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"{nameof(AlarmDate)} : {AlarmDate.ToString("MM/dd/yyyy HH:mm:ss")}");
            Console.WriteLine($"{nameof(AlarmMessage)} : {AlarmMessage}");
            Console.WriteLine($"{nameof(TimeToAlarm)} : {TimeToAlarm.ToString("c")}");
            Console.WriteLine($"{nameof(IsOutdated)} : {IsOutdated}");
            Console.WriteLine();
        }

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
    }
}
