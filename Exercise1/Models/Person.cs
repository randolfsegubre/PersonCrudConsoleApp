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
        public Person(string firstName, string lastName, string email)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public Person(string firstName, string _lastName, DateTime dateOfBirth)
        {
            Id = 0;
            FirstName = firstName;
            LastName = _lastName;
            DateOfBirth = dateOfBirth;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string ScreenName1 => FirstName + "." + LastName + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";

        public string ScreenName2 => FirstName.Substring(0, 1) + LastName + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";

        public string ScreenName3 => FirstName + LastName.Substring(0, 1) + DateOfBirth.ToString("MMddyyyy") + "@yahoo.com";
    }
}
