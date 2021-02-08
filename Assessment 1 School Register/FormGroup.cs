using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_1_School_Register
{
    class FormGroup
    {
        private string formName;
        private string teacherName;
        private Student[] Students;

        public FormGroup(string formName, string teacherName)
        {
            string FormName = formName;
            string TeacherName = teacherName;
            Students = new Student[25];

        }

    }
}
