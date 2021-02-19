using System;
using System.Collections.Generic;
using System.Text;

namespace ksis_lab1
{
    class ConsoleAnimationProvider : ITextAnimationContextProvider
    {
        public IAnimationProvider AnimationProvider { get; }

        public ConsoleAnimationProvider()
        {
            AnimationProvider = new Spinner();
        }
        public void WriteLine(string data)
        {
            Console.CursorLeft = 0;
            Console.WriteLine(data);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void StartAnimation()
        {
            AnimationProvider.Start();
        }

        public void StopAnimation()
        {
            AnimationProvider.Stop();
        }
    }
}
