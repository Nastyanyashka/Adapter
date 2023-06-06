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
        public int SecondHand
        {
            get { return digitalClock.Seconds; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();
                angleSecondHand = 6 * value;
                digitalClock.Seconds = value;
            }
        }
        public int MinuteHand
        {
            get { return digitalClock.Minutes; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentOutOfRangeException();

                angleMinuteHand = 6 * value;
                digitalClock.Minutes = value;
            }
        }
        public int HourHand
        {
            get { return digitalClock.Hours; }
            set
            {
                if (value < 0 || value > 12) throw new ArgumentOutOfRangeException();

                angleHourHand = (30 * value) % 360;
                digitalClock.Hours = value;
            }
        }
    }

}

