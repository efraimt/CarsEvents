using System;
using System.Collections.Generic;
using System.Timers;

namespace CarsComponents
{

    public enum Side { Left, Right }
    public enum Direction { Front, Back }
    public class Wheel
    {
        public Side Side { get; set; }
        public Direction Direction { get; set; }

        public int AirPressure { get { return new Random(DateTime.Now.GetHashCode()).Next(29, 38); } }
    }


    public class Car
    {
        //public Wheel RightFrontWhell { get; set; }
        List<Wheel> wheels = new List<Wheel>();


        public Car()
        {
            wheels.Add(new Wheel() {Direction=Direction.Front,Side=Side.Left });
            wheels.Add(new Wheel() { Direction = Direction.Front, Side = Side.Right });
            wheels.Add(new Wheel() { Direction = Direction.Back, Side = Side.Left });
            wheels.Add(new Wheel() { Direction = Direction.Back, Side = Side.Right });

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckAirPressure();
        }

        public event EventHandler<WheelEventArgs> WheelAirPressureLow;

        private void CheckAirPressure()
        {
            foreach (var wheel in wheels)
            {
                if (wheel.AirPressure < 34)
                {
                    OnWheelAirPressureLow(wheel);
                }
            }

        }

        protected virtual void OnWheelAirPressureLow(Wheel wheel)
        {
            if (WheelAirPressureLow != null)
                WheelAirPressureLow(this, new WheelEventArgs() { Wheel = wheel });
        }
    }

}
