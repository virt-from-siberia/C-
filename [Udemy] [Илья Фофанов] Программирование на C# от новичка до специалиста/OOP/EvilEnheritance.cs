namespace OOP
{
    public interface IShape
    {
        int CalcSquare();
    }
    public class Rect : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int CalcSquare()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public int SideLength { get; set; }
        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }
}