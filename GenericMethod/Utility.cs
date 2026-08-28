using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_C__Advanced.GenericMethod
{
    internal class Utility
    {
        //Swap method
        //Once use/when call the method will define the <T> data type.
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b;
            b = temp; // the old value of a.
        }

        //Find maximum number method
        //IComparable<T> guarantees that the type has a CompareTo method
        public static T Max<T>(T num1, T num2) where T : IComparable<T>
        {
            //CompareTo is essential for comparing values to find the maximum
            return num1.CompareTo(num2) > 0 ? num1 : num2;
        }
    }
}
