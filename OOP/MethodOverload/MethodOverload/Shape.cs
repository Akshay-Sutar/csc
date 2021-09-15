namespace MethodOverload
{
    class Shape
    {
        public float getDimension(float l, float b)
        {
            return (float)l * b;
        }

        public float getDimension(float l, float b, float h)
        {
            return (float)l * b * h;
        }
    }
}
