namespace NullCoalasceOp
{
    class NullCoalesceOp
    {
        int? _a;

        public NullCoalesceOp(int? value)
        {
            _a = value ?? 0;
        }
        public int getValue()
        {
            return _a ?? 0;
        }
    }
}
