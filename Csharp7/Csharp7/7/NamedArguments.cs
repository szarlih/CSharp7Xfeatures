namespace Csharp7._7
{
    using System;

    public class NamedArguments
    {
        public NamedArguments()
        {
            doSomething(1, b: "test", 2.0);
            doSomething(c: 3.0, b: "wow!", a:1);
        }

        private void doSomething(int a, string b, double c)
        {
            Console.WriteLine(string.Format("Arguments: {0}, {1}, {2}", a, b, c));
        }
    }
}
