using System;

namespace Assessment_1_School_Register
{
    class Program
    {
        static void Main(string[] args)
        {

            FormGroup y12FB = new FormGroup("y12FB", "Ms Blairs");
            y12FB.AddStudent("Em", DateTime.Parse("10/13/2004"), 'F'); // char uses single quote

            y12FB.AddStudent("Prem", DateTime.Parse("01/01/2004"), 'M');

            y12FB.AddStudent("Toy", DateTime.Parse("01/02/2004"), 'C');

            Menu(*);
           
        }

        static void Menu(Student[] students, Attendance[] attendances )
        {
            bool UserContinue = true;

            while  ( UserContinue == true)
            {
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1 : Enter attendence for each student");
                Console.WriteLine("2 : Check student's attendance");
                Console.WriteLine("3: input a student's profile");
                Console.WriteLine("0: end the program");

                string userInput =  Console.ReadLine();
                int userInputNumber = Convert.ToInt32(userInput);
                if (userInputNumber == 0)
                {
                    UserContinue = false;
                }
                else if (userInputNumber == 1)
                {
                    FormGroup.TakeAttendance();
                }
                else if (userInputNumber == 2)
                {

                }
                else if (userInputNumber == 3)
                {

                }
            }
        }
    }
}
