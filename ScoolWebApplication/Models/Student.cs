using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoolWebApplication.Models
{
    public class Student
    {
        string firstName;
         string lastName;
        int yearOfBirth;
        int grade;


        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public int Grade { get { return grade; } set { grade = value; } }

     public   Student() { }
      public  Student (string firstName, string lLastName, int yearOfBirth, int grade)
        {
            this.firstName = firstName;
            this.lastName = lLastName;
            this.yearOfBirth = yearOfBirth;
            this.grade = grade;


        }

    }
}