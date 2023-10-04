using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumToStringUsingNameof
{
    public enum DaysofWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class NameofTutorial
    {

        public static void ConverToStringUsignNameof(DaysofWeek day)
        {
            var dayString = nameof(day);
            Console.WriteLine(dayString);
        }
    }
}
