namespace Csharp7._7
{
    using Utils;

    class Deconstruction
    {
        public Deconstruction()
        {
            (var myX, _) = new Point(1, 2);
        }
    }
}
