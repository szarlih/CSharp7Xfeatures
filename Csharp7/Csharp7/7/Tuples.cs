namespace Csharp7._7
{
    using System;

    class Tuples
    {
        public Tuples()
        {
            (string thing, _, _) = GetProducts();

            // old, worse way
            Tuple<string, string, string> products = new Tuple<string, string, string>("a", "b", "c");

            //new
            (string first, string x, string z) otherProducts = ("a", "b", "c");

            var anotherProducts = (thing: "a", "b", like: "c");

            Console.WriteLine(anotherProducts.thing);
            Console.WriteLine(anotherProducts.like);
            Console.WriteLine(anotherProducts.Item2); // default

            if(anotherProducts != otherProducts)
            {
                Console.WriteLine("Nope");
            }
        }

        private (string, string, string) GetProducts()
        {
            return ("computer", "laptop", "smartphone");
        }
    }
}
