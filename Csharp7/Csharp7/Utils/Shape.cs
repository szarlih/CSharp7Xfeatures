namespace Csharp7.Utils
{
    public class Shape
    {
        public string Name { get; set; }

        protected int Corners => Name != "Circle" ? 3 : 0;
    }
}
