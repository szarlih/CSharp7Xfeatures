namespace OtherApp
{
    using Csharp7.Utils;
    using System;

    public class SomeCleverClass : Point
    {
        public SomeCleverClass(int x, int y) : base(x, y)
        {
            //Color = 13;
            Console.WriteLine(Corners);
        }
    }
}
