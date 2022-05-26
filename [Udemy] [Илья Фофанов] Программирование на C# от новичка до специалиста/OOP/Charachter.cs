using System;

namespace OOP
{
    public class Charachter
    {
        public int Health { get; private set; } = 100;
        public void Hit(int demage)
        {
            if (demage > Health)
                demage = Health;

            Health -= demage;

            Console.WriteLine(Health);
        }
    }
}