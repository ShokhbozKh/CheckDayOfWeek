using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class WeekDays
    {
        public string[] days = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };
        private int _dayOfWeek;
        public int DayOfWeek
        {
            get
            {
                return _dayOfWeek;
            }
            set
            {
                if (value > 0 && value < 8)
                {
                    _dayOfWeek = value;
                    Console.WriteLine($"Xaftaning:{days[_dayOfWeek-1]} kuni");
                }
                else
                {
                    Console.WriteLine($"xato kun:{value}");
                }
                
            }
        }
    }
}
