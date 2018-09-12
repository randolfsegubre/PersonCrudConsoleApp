using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class SunSign : Person
    {
        public String ZodiacSign
        {
            get
            {
                switch ((int)DateOfBirth.Month)
                {
                    case 1:
                        if (DateOfBirth.Day <= 20)
                        {
                            return "Capricorn";
                        }
                        else
                        {
                            return "Aquarius";
                        }
                        break;
                    case 2:
                        if (DateOfBirth.Day <= 19)
                        {
                            return "Aquarius";
                        }
                        else
                        {
                            return "Pisces";
                        }
                        break;
                    case 3:
                        if (DateOfBirth.Day <= 20)
                        {
                            return "Pisces";
                        }
                        else
                        {
                            return "Aries";
                        }
                        break;
                    case 4:
                        if (DateOfBirth.Day <= 20)
                        {
                            return "Aries";
                        }
                        else
                        {
                            return "Taurus";
                        }
                        break;
                    case 5:
                        if (DateOfBirth.Day <= 21)
                        {
                            return "Taurus";
                        }
                        else
                        {
                            return "Gemini";
                        }
                        break;
                    case 6:
                        if (DateOfBirth.Day <= 22)
                        {
                            return "Gemini";
                        }
                        else
                        {
                            return "Cancer";
                        }
                        break;
                    case 7:
                        if (DateOfBirth.Day <= 22)
                        {
                            return "Cancer";
                        }
                        else
                        {
                            return "Leo";
                        }
                        break;
                    case 8:
                        if (DateOfBirth.Day <= 23)
                        {
                            return "Leo";
                        }
                        else
                        {
                            return "Virgo";
                        }
                        break;
                    case 9:
                        if (DateOfBirth.Day <= 23)
                        {
                            return "Virgo";
                        }
                        else
                        {
                            return "Libra";
                        }
                        break;
                    case 10:
                        if (DateOfBirth.Day <= 23)
                        {
                            return "Libra";
                        }
                        else
                        {
                            return "Scorpio";
                        }
                        break;
                    case 11:
                        if (DateOfBirth.Day <= 22)
                        {
                            return "Scorpio";
                        }
                        else
                        {
                            return "Sagittarius";
                        }
                        break;
                    case 12:
                        if (DateOfBirth.Day <= 21)
                        {
                            return "Sagittarius";
                        }
                        else
                        {
                            return "Capricorn";
                        }
                        break;

                    default:
                        return "Your sun sign was not found! Please try again!";
                        break;
                }
            }

        }
    }
}
