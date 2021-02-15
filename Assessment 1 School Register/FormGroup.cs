using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class FormGroup
    {
        private static int maxStudents = 25;
        private string FormName;
        private string TeacherName;
        private Student[] Students = new Student[maxStudents];
        private int studentCount = 0;

        public FormGroup(string FormName, string TeacherName)
        {
            this.FormName = FormName;
            this.TeacherName = TeacherName;

        }

        public void AddStudent(string StudentName, DateTime StudentDOB, char StudentGender)
        {
            Students[studentCount] = new Student(StudentName, StudentDOB, StudentGender);
            studentCount++;
            
        }
        
        public void TakeAttendance(DateTime date )
        {
            string attendanceInput = " ";
            
            for(int i = 0; i < maxStudents; i++)
            {
                if (Students[i] != null)
                {
                    Console.WriteLine("Is student ", Students[i], " present?");
                    attendanceInput = Console.ReadLine();
                    //Students[i] = attendanceInput;

                }
            }
        }

        public void ShowAttendance(Student[] students)
        {
            for(int i = 0; i < maxStudents; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

    }
}
