using System;

namespace Generics
{
    class Stack<TData>
    {
        private TData[] _stack = new TData[10];
        private int _index = -1;

        public int push(TData item)
        {
            if (this._index >= 10)
            {
                throw new Exception("Stack overflow");
            }
            this._stack[++this._index] = item;
            return this._index;
        }

        public TData pop()
        {
            if (this._index <= 0)
            {
                throw new Exception("Stack underflow");
            }
            return this._stack[this._index--];
        }

        public void print()
        {
            for (int i = 0; i <= this._index; ++i)
            {
                Console.WriteLine(this._stack[i]);
            }
        }
    }
}
