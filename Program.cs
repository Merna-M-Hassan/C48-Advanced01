namespace Assignment_10_C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)
            //What is a generic class? Why use generics?

            /*
             * Is a class without a defined data type (string/double/int/..etc) for its field, until using it. Instead, it has a placeholder for
             * the data type is defined when using the class. Once an object/instance is created from the generic class, the data type must be defined.
             * 
             * Use generics because we need to apply the following: 
             * - To make code reusability:  reuse the class in different data types.
             * - Need all fields/properties to have the same defined data type.
             * - Enforce compiler type safety (check for values are compatible with the defined data type)
             */
            #endregion

            #region Q2)
            // Write a generic class Container<T> with Add and Get methods.

            //Container<string> names = new Container<string>(5);

            //names.Add("Ali");
            //names.Add("Mariam");
            //names.Add("Faya");
            //names.Add("Lara");

            //Console.WriteLine(names.Get(1));        
            #endregion

            #region Q3)
            //What are multiple type parameters? Write Pair<TKey, TValue>?

            /*
             * Allow a generic class to work with more than one type parameter at the same time (not just have a one placeholder).
             * The class own more than one generic type. Use it when need to apply more than one data type.
             */

            Pair<int, string> empLogin = new Pair<int, string>(20, "Ali");

            Console.WriteLine($"{empLogin.Id}-{empLogin.Name}");
            #endregion
        }
    }
}
