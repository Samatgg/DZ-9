namespace Тумаков_10лаб.Exercise_2
{
    public class Rectangle : Point
    {
        private int width;
        private int height;

        public Rectangle(string color, bool visible, int width, int height) : base(color, visible)
        {
            this.width = width;
            this.height = height;
        }

        public int CalculateArea()
        {
            return this.width * this.height;
        }
    }
}
