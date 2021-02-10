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

        public FormGroup(string FormName, string TeacherName)
        {
            this.FormName = FormName;
            this.TeacherName = TeacherName;

        }

        
    }
}
