namespace Csharp7._7
{
    using System;
    public class DigitalSeparators
    {
        public DigitalSeparators()
        {
            var number = 1_000_000;

            number = 54_____000_000;

            number = 0x00_00_00;

            number = 0B11_00_0011;

            Console.WriteLine(number);
        }
    }
}
