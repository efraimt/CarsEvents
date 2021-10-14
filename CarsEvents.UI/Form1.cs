using CarsComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsEvents.UI
{
    public partial class Form1 : Form
    {
        Car car = new Car();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car.WheelAirPressureLow += Car_WheelAirPressureLow;

            car.WheelAirPressureLow += delegate (object? sender, WheelEventArgs e)
            {
                //Send email to KIA
                Debug.WriteLine("Sending email...");
            };
            
        }

        private void Car_WheelAirPressureLow(object? sender, WheelEventArgs e)
        {
            switch (e.Wheel.Side)
            {
                case Side.Left:
                    switch (e.Wheel.Direction)
                    {
                        case Direction.Front:
                            lblFrontLeft.BackColor = Color.Red;
                            //lblFrontLeft.Text = e.Wheel.AirPressure.ToString();
                            break;
                        case Direction.Back:
                            lblBackLeft.BackColor = Color.Red;
                            //lblBackLeft.Text = e.Wheel.AirPressure.ToString();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    switch (e.Wheel.Direction)
                    {
                        case Direction.Front:
                            lblFrontRight.BackColor = Color.Red;
                            //lblFrontRight.Text = e.Wheel.AirPressure.ToString();
                            break;
                        case Direction.Back:
                            lblBackRight.BackColor = Color.Red;
                            //lblBackRight.Text = e.Wheel.AirPressure.ToString();
                            break;
                        default:
                            break;
                    }
                    break;
                    
            }
        }
    }
}
