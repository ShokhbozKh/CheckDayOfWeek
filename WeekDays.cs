using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class WeekDays
    {
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
                }
                else
                {
                    Console.WriteLine($"xato kun:{value}");
                }
                
            }
        }
    }
}
