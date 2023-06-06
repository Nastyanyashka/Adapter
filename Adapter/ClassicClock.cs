using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class ClassicClock
    {
        int secondHand;
        int minuteHand;
        int hourHand;
        
        double angleSecondHand;
        double angleMinuteHand;
        double angleHourHand;
        public ClassicClock() { }
        void CalculateAngles()
        {
            angleSecondHand = 6 * secondHand;
            angleMinuteHand = 6 * minuteHand;
            angleMinuteHand += minuteHand / 10;
            angleHourHand = (hourHand * 30) % 360;
            angleHourHand += minuteHand / 2;
            angleHourHand += secondHand / 120;
        }
        public int SecondHand { get { return secondHand; }set {
                if (value < 0 || value > 59) throw new ArgumentOutOfRangeException();
                secondHand = value;
                CalculateAngles();
            }
        }
        public int MinuteHand { get { return minuteHand; } set {
                if (value < 0 || value > 59) throw new ArgumentOutOfRangeException();
                minuteHand = value;
                CalculateAngles();
            } 
        }
        public int HourHand { get { return hourHand; } set {
                if (value < 0 || value > 12) throw new ArgumentOutOfRangeException();
                CalculateAngles();
                hourHand = value;
            } 
        }
    }
}
