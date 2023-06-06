using System;
using System.Collections.Generic;
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
        public int SecondHand { get { return secondHand; }set {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();
                angleSecondHand = 6*value;
                secondHand = value; } }
        public int MinuteHand { get { return minuteHand; } set {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();

                angleMinuteHand = 6*value;
                minuteHand = value; } }
        public int HourHand { get { return hourHand; } set {
                if (value < 0 || value > 12) throw new ArgumentOutOfRangeException();

                angleHourHand = (30*value)%360;
                hourHand = value; } }
    }
}
