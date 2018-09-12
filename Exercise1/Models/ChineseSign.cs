using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class ChineseSign : Person
    {
        public string Horoscope
        {
            get
            {
                EastAsianLunisolarCalendar cc = new ChineseLunisolarCalendar();
                int sexagenaryYear = cc.GetSexagenaryYear(DateOfBirth);
                int terrestrialBranch = cc.GetTerrestrialBranch(sexagenaryYear);

                string[] years = new string[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

                return years[terrestrialBranch - 1];
            }
        }
    }
}
