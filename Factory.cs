using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced
{
    internal class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
