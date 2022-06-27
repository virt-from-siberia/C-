using System;

namespace OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Charachter
    {
        private readonly int speed;

        public int PrintSpeed()
        {
            /*Console.WriteLine($"speed = {speed}");*/
            return speed;
        }

        public void IncreaceSpeed()
        {
            Console.WriteLine($"speed = {speed}");
        }

        public int Health { get; private set; } = 100;
        public string Race { get; private set; }
        public int Armor { get; private set; }

        public string Name { get; private set; }

        public Charachter(string race, int armor = 30)
        {
            Race = race;
            Armor = armor;
        }

        public Charachter(string name, int armor, bool with)
        {
            if (name == null)
                throw new ArgumentNullException("Name arg can not be null");
            if (armor < 0 || armor > 100)
                throw new ArgumentException("Armor con not be less then 0 and greater than 100");
        }

        public Charachter(string race, int armor, int speed)
        {
            Race = race;
            Armor = armor;
            this.speed = speed;
        }

        public void Hit(int demage)
        {
            if (Health == 0)
                throw new InvalidOperationException("Can not hit a dad character");
            if (demage > Health)
                demage = Health;
            Health -= demage;
            Console.WriteLine(Health);
        }
    }
    
    public class CreditCrdWithDrawException : Exception
    {
            
    }
}