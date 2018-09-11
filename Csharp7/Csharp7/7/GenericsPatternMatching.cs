namespace Csharp7._7
{
    using Csharp7.Utils;
    using System;

    class GenericsPatternMatching
    {
        public GenericsPatternMatching()
        {
            PrintShape(new Circle() { Radius = 6 });
            PrintClass(new Point(1, 2));
        }

        private void PrintShape<T>(T shape) where T:Shape
        {
            switch (shape)
            {
                case Rectangle r:
                    Console.WriteLine("Rectangle");
                    break;
                case Circle r:
                    Console.WriteLine("Circle");
                    break;
                default:
                    Console.WriteLine("General shape");
                    break;
            }
        }

        private void PrintClass<T>(T shape) where T : class
        {
            switch (shape)
            {
                case Rectangle r:
                    Console.WriteLine("Rectangle");
                    break;
                case Circle r:
                    Console.WriteLine("Circle");
                    break;
                case Point p:
                    Console.WriteLine("Point");
                    break;
                default:
                    Console.WriteLine("General shape");
                    break;
            }
        }
    }
}
