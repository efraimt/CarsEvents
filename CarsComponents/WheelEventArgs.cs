using System;

namespace CarsComponents
{
    public class WheelEventArgs: EventArgs
    {
        public Wheel Wheel{ get; set; }
    }
}