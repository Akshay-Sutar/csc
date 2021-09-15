namespace OperatorOverload
{
    class Point
    {
        private float x, y;
        public Point(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point a ,Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
        public override string ToString()
        {
            return $"{this.x}, {this.y}";
        }
    }
}
