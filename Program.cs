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

            #region Q8)
            //What is the 'class' constraint? Write an example.

            /*
             * The accepted reference data type is only a class/interface/array/string.
             */

            //Print<string>("Lili");   
            #endregion

            #region Q9)
            //What is the 'new()' constraint? Write an example.

            /*
             * Parameterless constructor constraint: the defined generic data type must have a public parameterless constructor, to use it as a type to the T.
             */

            //Factory<Person> factory01 = new Factory<Person>();
            //Person person01 = factory01.Create();

            //person01.Name = "Lili";
            //person01.Age = 30;

            //Console.WriteLine($"Name: {person01.Name}, Age: {person01.Age}");
            #endregion

            #region Q10)
            //What is the interface constraint? Write an example.

            /*
             * Must defined an interface in a generic placeholder, to be implemented
             */

            //SoundMaker<Dog> dog = new SoundMaker<Dog>();
            //dog.MakeSound(new Dog());  

            //SoundMaker<Cat> cat = new SoundMaker<Cat>();
            //cat.MakeSound(new Cat());  
            #endregion

            #region Q11)
            //What is the base class constraint? Write an example.

            /*
             * The defined data type of generic placeholder must be from base/parent class, not derived/child class.
             */

            //// Create animals
            //Dog dog = new Dog { Name = "Rex" };
            //Cat cat = new Cat { Name = "Whiskers" };

            //// Create processors
            //AnimalProcessor<Dog> dogProcessor = new AnimalProcessor<Dog>();
            //AnimalProcessor<Cat> catProcessor = new AnimalProcessor<Cat>();

            //// Process animals
            //Console.WriteLine("Processing Dog:");
            //dogProcessor.Process(dog);
            //dog.Bark();

            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine("Processing Cat:");
            //catProcessor.Process(cat);
            //cat.Meow();
            #endregion

            #region Q12)
            //How do you apply multiple constraints? Write an example.

            /*
             * By combining them using a comma-separated list
             */

            EmployeeManager<Employee> manager = new EmployeeManager<Employee>();

            Employee emp = manager.CreateDefault();
            emp.Name = "Lili";

            manager.Manage(emp);
            #endregion
        }

        //Q8) Example method
        //public static void Print<T>(T value) where T : class
        //{
        //    Console.WriteLine(value);
        //}

        // --------------------------------------------------------------------------------------------//

        //Q10)
        //public interface IAnimal
        //{
        //    void MakeSound();
        //}

        //public class Dog : IAnimal
        //{
        //    public void MakeSound() => Console.WriteLine("Woof!");
        //}

        //public class Cat : IAnimal
        //{
        //    public void MakeSound() => Console.WriteLine("Meow!");
        //}

        //public class SoundMaker<T> where T : IAnimal
        //{
        //    public void MakeSound(T animal) => animal.MakeSound();
        //}

        // --------------------------------------------------------------------------------------------//

        //Q11)
        //public class Animal
        //{
        //    public string Name { get; set; }
        //    public void Eat() => Console.WriteLine($"{Name} is eating");
        //    public void Sleep() => Console.WriteLine($"{Name} is sleeping");
        //}

        //public class Dog : Animal
        //{
        //    public void Bark() => Console.WriteLine($"{Name} says: Woof!");
        //}

        //public class Cat : Animal
        //{
        //    public void Meow() => Console.WriteLine($"{Name} says: Meow!");
        //}

        //public class AnimalProcessor<T> where T : Animal  // Base class constraint!
        //{
        //    public void Process(T animal)
        //    {
        //        animal.Eat();
        //        animal.Sleep(); 
        //        Console.WriteLine($"\nProcessing {animal.Name}:"); 
        //    }
        //}

        // --------------------------------------------------------------------------------------------//

        // Q12)
        // Base class
        public class Person
        {
            public string Name { get; set; }
            public void SayHello() => Console.WriteLine($"Hello, I'm {Name}");
        }

        // Interface
        public interface IWorker
        {
            void Work();
        }

        // Interface
        public interface IRest
        {
            void Rest();
        }

        // Class that meets all constraints
        public class Employee : Person, IWorker, IRest
        {
            public Employee() { } // Parameterless constructor

            public void Work() => Console.WriteLine($"{Name} is working");
            public void Rest() => Console.WriteLine($"{Name} is resting");
        }

        // Generic class with multiple constraints
        public class EmployeeManager<T> where T : Person, IWorker, IRest, new()
        {
            public void Manage(T employee)
            {
                Console.WriteLine($"Managing {employee.Name}:");
                employee.SayHello(); // From Person
                employee.Work();     // From IWorker
                employee.Rest();     // From IRest
                Console.WriteLine();
            }

            public T CreateDefault()
            {
                T employee = new T();
                employee.Name = "Default Employee";
                return employee;
            }
        }
    }
}
