using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_1
{
    public class Student
    {
        private int _studentId;
        private string _firstName;
        private string _lastName;
        private char _grade;

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public char Grade { get; set; }
        public Student(int StudentId, string FirstName, string LastName, char Grade)
        {
            _studentId = StudentId;
            _firstName = FirstName;
            _lastName = LastName;
            _grade = Grade;

        }
        public Student()
        {
                
        }
    }

}
