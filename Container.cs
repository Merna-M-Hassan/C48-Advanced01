using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_10_C__Advanced
{
    internal class Container<T>
    {
        // Is will be array of string/int/double/...etc.?
        private T[] items;

        //Tracks how many items are currently stored
        private int count;

        //A constructor that takes the maximum number of items this container can hold
        public Container(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }

        //The method that adds an item to the container
        public void Add(T item)
        {
            //Checks if there's space in the array
            if (count < items.Length)
            {
                //Stores the item at the current count position, then increments count by 1.
                //count++ means "use the current value of count, then add 1 to it"
                items[count++] = item;
            }
        }

        //The method that retrieves an item at a specific position.
            //Takes an int parameter representing the position to look at.
        public T Get(int index)
        {
            //index >= 0 → Index can't be negative (arrays start at 0).
            //index < count → Index must be less than the number of items stored.
            if (index >= 0 && index < count) 
            {
                // Returns the item at the specified index.
                //If the index is valid, we simply return whatever is stored at that array position.
                return items[index];
            }

            //default(T) returns:
               //null for reference types (like string, object).
              //0 for numeric types (like int, double)
             //false for bool
               return default(T);
        }
    }
}
