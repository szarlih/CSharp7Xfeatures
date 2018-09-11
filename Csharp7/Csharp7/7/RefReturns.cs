namespace Csharp7._7
{
    using System;

    class RefReturns
    {
        private int[] array = { -5, 65, 5, 0, -7, 32, -1, 19, 21 };

        public RefReturns()
        {
            ref /* readonly */ int place = ref Find(5);
            place = 9;

            Console.WriteLine(array[2]);

            doSomething(-1);
        }

        public ref int Find(int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return ref array[i];
                }
            }

            throw new IndexOutOfRangeException($"{nameof(number)} not found");
        }

        private ref int doSomething(int x)
        {
            return ref (x > 0 ? ref array[1] : ref array[0]);
        }
    }
}
