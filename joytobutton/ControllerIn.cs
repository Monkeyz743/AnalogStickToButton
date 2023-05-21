using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using SharpDX.XInput;
using WindowsInput;

namespace joytobutton
{
    public class ControllerIn
    {
        private Controller _controller;
        private IMouseSimulator _mouseSimulator;
        private Timer _timer;
        private const int RefreshRate = 60;

        public ControllerIn()
        {
            _controller = new Controller(UserIndex.One);
            _mouseSimulator = new InputSimulator().Mouse;
            _timer = new Timer(obj => Update());
        }

        public int XInput()
        {
            _controller.GetState(out var state);
            var x = (state.Gamepad.LeftThumbX + 32768) / 1_00;

            return x;
        }
        public int YInput()
        {
            _controller.GetState(out var state);
            var y = (state.Gamepad.LeftThumbY + 32768) / 1_00;

            return y;
        }

        public void Start()
        {
            _timer.Change(0, 1000 / RefreshRate);
        }

        private void Update()
        {
            _controller.GetState(out var state);
            var x = (state.Gamepad.LeftThumbX + 32768) / 1_00 / 1.5;
            var y = (state.Gamepad.LeftThumbY + 32768) / 1_00 / 1.5;

            //Debug.WriteLine($"X={state.Gamepad.LeftThumbX}  Y={state.Gamepad.LeftThumbY}");
            Debug.WriteLine($"X={x}  Y={y}");
            Debug.WriteLine("\r\n");



        }


    }

    

}
