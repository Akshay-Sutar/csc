namespace ConstructorChaining
{
    class Child : Base
    {
        private int _c;
        public Child(int c) : base(0)
        {
            this._c = c;
        }

        public Child(int c, int b) : this(c)
        {
            this.b = b;
        }

        public override string ToString()
        {
            return $" b = {this.b} , c = {this._c}";
        }
    }
}
