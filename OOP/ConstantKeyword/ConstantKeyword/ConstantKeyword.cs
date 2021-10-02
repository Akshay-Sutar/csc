namespace ConstantKeyword
{
    class ConstantKeyword
    {
        //compile time constants that needs to be defined during declaration
        private const float _pi = 3.1419f;

        public float getArea(float radius)
        {
            return _pi * radius * radius;
        }

        public float getVolume(float radius, float height)
        {
            return getArea(radius) * height;
        }
    }
}
