namespace Тумаков_10лаб.Exercise_2
{
    public class Circle : Point
    {
        private int radius;

        public Circle(string color, bool visible, int radius) : base(color, visible)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return 3.14 * this.radius * this.radius;
        }
    }
}
