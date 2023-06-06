using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class DigitalClock
    {
        int seconds;
        int minutes;
        int hours;
        public DigitalClock() { }

        public int Seconds { get { return seconds; } set { 
                if (value<0 ||  value > 59) throw new ArgumentOutOfRangeException();
                seconds = value; } }
        public int Minutes { get { return minutes;} set {

                if (value < 0 || value > 59) throw new ArgumentOutOfRangeException();
                seconds = value; } }
        public int Hours { get { return hours;} set {
                if (value < 0 || value > 12) throw new ArgumentOutOfRangeException();
                hours = value; } }
    }
}
