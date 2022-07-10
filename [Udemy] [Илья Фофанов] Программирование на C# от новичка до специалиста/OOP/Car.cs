using System;

namespace OOP
{
    public class Car
    {
        static int speed = 0;

        public event EventHandler<int> TooFastDriving;

        // public delegate void TooF ast(int currentSpeed);

        // private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                    TooFastDriving(this, speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        // public void RegisterOnTooFast(TooFast tooFast) => this.tooFast += tooFast;
        //
        // public void unRegisterOnToFast(TooFast tooFast) => this.tooFast -= tooFast;
    }
}