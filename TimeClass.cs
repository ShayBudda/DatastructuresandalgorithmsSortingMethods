﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNotes
{
    internal class Time
    {
        public int hour, minute;
        public double second;

        //Here is an example for the time class
        public Time()
        {
            hour = 1;
            minute = 2;
            second = 3.0;
                }
        public Time(int hour, int minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}
