namespace Csharp7._7
{
    using System;
    using System.Collections.Concurrent;

    class ExpressionBodied
    {
        private static int counter = 1;
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
        private int id = GetId();

        public ExpressionBodied(string name) => names.TryAdd(id, name);
        ~ExpressionBodied() => names.TryRemove(id, out _);

        public string Name
        {
            get => names[id];
            set => names[id] = value;
        }

        public string GetName() => throw new NotImplementedException();

        private static int GetId()
        {
            return counter;
        }
    }
}
