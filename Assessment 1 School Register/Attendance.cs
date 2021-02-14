using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Attendance
    {
        private DateTime Date;
        private string DayOfWeek;
        private bool Present;
        private int MinutesLate;

        public Attendance(DateTime Date, bool Present,int MinutesLate)
        {
            this.Date = Date;
            this.Present = Present;
            this.MinutesLate = MinutesLate;

            DayOfWeek = Date.ToString("dddd"); 

        }

        public DateTime GetDate()
        {
            return Date;
        }

        public string GetDOW()
        {
            return DayOfWeek;
        }

        public bool GetPresent()
        {
            return Present;
        }

        public int GetMinsLate()
        {
            return MinutesLate;
        }

    }
}
