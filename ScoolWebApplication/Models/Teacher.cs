using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoolWebApplication.Models
{
    public class Teacher
    {

        string firstName;
        string lastName;
        int yearOfBirth;
        int payment;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public int Payment { get { return payment; } set { payment = value; } }

        public Teacher() { }
        public Teacher(string firstName, string lLastName, int yearOfBirth, int payment)
        {
            this.firstName = firstName;
            this.lastName = lLastName;
            this.yearOfBirth = yearOfBirth;
            this.payment = payment;


        }

    }
}









