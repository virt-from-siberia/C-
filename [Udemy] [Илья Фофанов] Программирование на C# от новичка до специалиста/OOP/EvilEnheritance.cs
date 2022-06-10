namespace OOP
{
    public class Rect
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Square : Rect
    {
        
    }


    public static class AriaCalculator
    {
        public static int CalcSquare(Square square)
        {
            return square.Height * square.Height;
        }

        public static int CalcSquare(Rect rect)
        {
            rect.Width = rect.Height;
        }
    }
}