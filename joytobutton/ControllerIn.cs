using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
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

        public void Start()
        {
            _timer.Change(0, 1000 / RefreshRate);
        }

        private void Update()
        {
            _controller.GetState(out var state);
            var x = state.Gamepad.LeftThumbX / 2_000;
            MessageBox.Show($"Hello. {x}");
        }
    }
}
