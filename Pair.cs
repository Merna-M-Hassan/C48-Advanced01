using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced
{
    internal class Pair<TKey, TValue>
    {
        public TKey Id {  get; set; }
        public TValue Name { get; set; }

        public Pair(TKey first, TValue second)
        {
            Id = first;
            Name = second; 
        }
    }
}
