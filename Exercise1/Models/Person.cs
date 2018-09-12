using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Person
    {
        public Person()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
            Email = "";
            DateOfBirth = DateTime.Now;
        }
        public Person(string _firstName, string _lastName, string _email)
        {
            Id = 0;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
        }
        public Person(string _firstName, string _lastName, DateTime _dateOfBirth)
        {
            Id = 0;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
        }
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public String ScreenName1
        {
            get
            {
                return FirstName + "." + LastName + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";
            }
        }
        public String ScreenName2
        {
            get
            {
                return FirstName.Substring(0, 1) + LastName + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";
            }
        }
        public String ScreenName3
        {
            get
            {
                return FirstName + LastName.Substring(0, 1) + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";
            }
        }
    }
}
