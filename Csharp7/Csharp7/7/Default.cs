namespace Csharp7._7
{
    using System.Collections.Generic;

    class Default
    {
        public Default()
        {
            int a = default;
            int b = default(int);

            List<string> list = default;

            Dictionary<int, string> dictionary = default;

            var x = default(int?);

            // old way
            Dictionary<int, string> oldDictionary = default(Dictionary<int, string>);
        }
    }
}
