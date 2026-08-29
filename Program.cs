using Assignment_10_C__Advanced.GenericMethod;

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

            //Pair<int, string> empLogin = new Pair<int, string>(20, "Ali");

            //Console.WriteLine($"{empLogin.Id}-{empLogin.Name}");
            #endregion

            #region Q4)
            //What is a generic method? Write Swap<T> method.

            /*
             *Method can accept diffferent types of parameters thar are defined when the method ia called.
             *Use generic method to make the code reusable, use the same method each time want to make change in data types for method's parameters.
             */

            //int a = 5, b = 6;

            //Utility.Swap<int>(ref a, ref b);
            //Console.WriteLine($"a = {a}\nb = {b}");
            #endregion

            #region Q5)
            //Write a generic method FindMax<T> that finds maximum value.

            //int  numberOne = 50, numberTwo = 100;

            // Console.WriteLine(Utility.Max<int>(numberOne, numberTwo)); ;
            #endregion

            #region Q6)
            //What is a generic interface? Write IRepository<T>.

            /*
             * Defines a contract that can work with any data type. Don't care what that type until implement the interface.
             * Any class/struct implement the generic interface will defines the data type.
             */

            //Product product01 = new Product(201, "Laptop", 16.500m);
            //Product product02 = new Product(203, "TV", 60.00m);
            //Product product03 = new Product(206, "Smart Watch", 10.500m);

            //ProductRepository repository = new ProductRepository();

            //repository.Add(product01);
            //repository.Add(product02);
            //repository.Add(product03);

            //List<Product> products = repository.GetAll();

            //Product p01 = repository.GetById(206);

            //repository.Delete(203);
            #endregion

            #region Q7)
            //What is the 'struct' constraint? Write an example.

            /*
             * The accepted value type of the generic placeholder is only a struct (value) type, not accepted anything else.
             */

            //int a = 20, b = 30;

            //Utility.Swap<int>(ref a, ref b);
            //Console.WriteLine($"a = {a}\nb = {b}");
            #endregion
        }
    }
}
