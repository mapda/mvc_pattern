using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIdentification
{
    

        class StudentView
        {
            public void printStudentDetails(String studentName, String studentRollNo)
            {
                System.Console.WriteLine("Student: ");
                System.Console.WriteLine("Name: " + studentName);
                System.Console.WriteLine("Roll No: " + studentRollNo);

            }
        }

    
}
