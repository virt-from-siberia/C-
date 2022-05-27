using System;

namespace OOP
{
   public struct PointVal
    {
        public int x;
        public int y;

        public void LogValues()
        {
            Console.WriteLine($"X={x} ; Y={y}");
        }
    }
   public  class PointRef
   {
       public int x;
       public int y;

       public void LogValues()
       {
           Console.WriteLine($"X={x} ; Y={y}");
       }
   }
}