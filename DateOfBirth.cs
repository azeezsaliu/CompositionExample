﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class DateOfBirth
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public void Init(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;

        }


    }

    

}
