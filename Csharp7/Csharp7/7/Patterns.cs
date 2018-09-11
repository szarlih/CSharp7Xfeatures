namespace Csharp7._7
{
    using Csharp7.Utils;
    using System;

    class Patterns
    {
        public Patterns()
        {
            newSwitch(new Rectangle() { Length = 20, Height= 20, Name="brick" });
            whatIsWhat(null);
        }

        private void newSwitch(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when (s.Length == s.Height):
                    Console.WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
                default:
                    Console.WriteLine("<unknown shape>");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
            }
        }

        private void whatIsWhat(object test)
        {
            if (test is null)
            {
                Console.WriteLine("It's null!");
            }

            if (test is int i || (test is string s && int.TryParse(s, out i)))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("other");
        }
    }
}
