namespace ValueTypeReferenceType
{
    class Point
    {
        public int X, Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void swap()
        {
            int z = X;
            X = Y;
            Y = z;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
