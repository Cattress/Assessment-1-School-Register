﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class Student
    {
        private string StudentName;
        private DateTime StudentDoB;
        private char StudentGender;
        private Attendance[] Attendances = new Attendance[180];
        private int attendanceCount = 0;
         
            
        public Student(string StudentName, DateTime StudentDoB, char StudentGender )
        {
            this.StudentName = StudentName;
            this.StudentDoB = StudentDoB;
            this.StudentGender = StudentGender;

        }

        public void AddAttendance( DateTime Date, bool Present, int MinutesLate) // this is right already btw 
        {
            Attendances[attendanceCount] = new Attendance(Date, Present, MinutesLate);
            attendanceCount++;
        }

        public int CalculateTotalPresent() 
        {
            int totalPr = 0;

            for (int i = 0; i < 180; i++)
            {
                if (Attendances[i] != null && (Attendances[i].GetPresent() == true))
                {
                    totalPr++;
                }
            }
            return totalPr;
        }

        public int CalculateTotalAbsent()
        {
            int totalAb = 0;

            for (int i = 0; i < 180; i++)
            {
                if (Attendances[i] != null && (Attendances[i].GetPresent() == false))
                {
                    totalAb++;
                }
            }
            return totalAb;
        }

       
        public int CalculateTotalLateDays()
        {
            int totalLt = 0;

            for (int i = 0; i < 180; i++)
            {
                if (Attendances[i] != null && (Attendances[i].GetMinsLate() != 0))
                {
                    totalLt++;
                }
            }
            return totalLt;
        }
        
        //public int CalculateTotalLateMins()
        //{

       // }
        
    }
}
