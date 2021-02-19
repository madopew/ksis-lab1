using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ksis_lab1
{
    public class Spinner : IAnimationProvider
    {
        private const string Sequence = @"/-\|";
        private int _counter;
        private readonly int _delay;
        private bool _active;
        private readonly Thread _thread;

        public Spinner(int delay = 100)
        {
            this._delay = delay;
            _thread = new Thread(Spin);
        }

        public void Start()
        {
            _active = true;

            if (!_thread.IsAlive)
            {
                _thread.Start();
            }
        }

        public void Stop()
        {
            _active = false;
            Console.CursorLeft = 1;
            Draw(' ');
        }

        private void Spin()
        {
            while (_active)
            {
                Turn();
                Thread.Sleep(_delay);
            }
        }

        private void Draw(char c)
        {
            Console.CursorLeft = 1;
            Console.Write(c);
        }

        private void Turn()
        {
            Draw(Sequence[++_counter % Sequence.Length]);
        }
    }
}
