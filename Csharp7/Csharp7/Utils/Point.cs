namespace Csharp7.Utils
{
    public class Point : Shape
    {
        public int X { get; }
        public int Y { get; }

        protected private int Color { get; set; }

        public Point(int x, int y) { X = x; Y = y; }
        public void Deconstruct(out int x, out int y) { x = X; y = Y; }
    }
}
