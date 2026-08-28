using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced.GenericMethod
{
    internal class Utility
    {
        //Swap to int
        //Just who use/when call the method will define the <T> data type.
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b;
            b = temp; // the old value of a.
        }
    }
}
