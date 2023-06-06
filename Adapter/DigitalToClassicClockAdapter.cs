using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class DigitalToClassicClockAdapter
    {
        double angleSecondHand;
        double angleMinuteHand;
        double angleHourHand;
        DigitalClock digitalClock = new DigitalClock();
        public DigitalToClassicClockAdapter(DigitalClock digitalClock) {
            this.digitalClock = digitalClock;
        }
        void CalculateAngles()
        {
            angleSecondHand = 6 * digitalClock.Seconds;
            angleMinuteHand = 6 * digitalClock.Minutes;
            angleMinuteHand += digitalClock.Minutes / 10;
            angleHourHand = (digitalClock.Hours * 30) % 360;
            angleHourHand += digitalClock.Minutes / 2;
            angleHourHand += digitalClock.Seconds / 120;
        }
        public int SecondHand
        {
            get { return digitalClock.Seconds; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();
                digitalClock.Seconds = value;
            }
        }
        public int MinuteHand
        {
            get { return digitalClock.Minutes; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();
                digitalClock.Minutes = value;
            }
        }
        public int HourHand
        {
            get { return digitalClock.Hours; }
            set
            {
                if (value < 0 || value > 12) throw new ArgumentOutOfRangeException();
                digitalClock.Hours = value;
            }
        }
    }

}

