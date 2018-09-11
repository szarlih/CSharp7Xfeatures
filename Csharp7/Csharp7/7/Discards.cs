namespace Csharp7._7
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class Discards
    {
        public Discards()
        {
            Calculate(4, 4, out int sum, out int _, out _);
            _ = RandomNumber();
            Console.WriteLine(sum);

            if(sum is double)
            {
                Console.WriteLine("double!");
            }
            else if(sum is var _)
            {
                Console.WriteLine("I can catch it even if I'm not sure what type is it");
            }

            printNumbers(4);
        }


        private void Calculate(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }

        private int RandomNumber()
        {
            var random = new Random();
            return random.Next();
        }

        private void printNumbers(int maxNumber)
        {
            _ = Task.Run(() => {
                for (int i = 1; i < maxNumber; i += 2)
                {
                    Console.Write($"{i}\t");
                    Thread.Sleep(500);
                }
            });

            Task.Delay(300 * maxNumber).Wait();
        }
    }
}
