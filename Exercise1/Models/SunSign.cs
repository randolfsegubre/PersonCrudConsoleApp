using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class SunSign : Person
    {
        public string ZodiacSign
        {
            get
            {
                switch ((int)DateOfBirth.Month)
                {
                    case 1:
                        return DateOfBirth.Day <= 20 ? "Capricorn" : "Aquarius";
                    case 2:
                        return DateOfBirth.Day <= 19 ? "Aquarius" : "Pisces";
                    case 3:
                        return DateOfBirth.Day <= 20 ? "Pisces" : "Aries";
                    case 4:
                        return DateOfBirth.Day <= 20 ? "Aries" : "Taurus";
                    case 5:
                        return DateOfBirth.Day <= 21 ? "Taurus" : "Gemini";
                    case 6:
                        return DateOfBirth.Day <= 22 ? "Gemini" : "Cancer";
                    case 7:
                        return DateOfBirth.Day <= 22 ? "Cancer" : "Leo";
                    case 8:
                        return DateOfBirth.Day <= 23 ? "Leo" : "Virgo";
                    case 9:
                        return DateOfBirth.Day <= 23 ? "Virgo" : "Libra";
                    case 10:
                        return DateOfBirth.Day <= 23 ? "Libra" : "Scorpio";
                    case 11:
                        return DateOfBirth.Day <= 22 ? "Scorpio" : "Sagittarius";
                    case 12:
                        return DateOfBirth.Day <= 21 ? "Sagittarius" : "Capricorn";
                    default:
                        return "Your sun sign was not found! Please try again!";
                }
            }
        }
    }
}
