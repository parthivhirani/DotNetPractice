using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CSharpPractice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // types of variable
            Console.WriteLine("--Basic Datatypes--");
            int integer1 = 3;
            string string1 = "hello";
            float float1 = 3.67F;
            double double1 = 5.23D;
            bool bool1 = true;

            Console.WriteLine($"Integer: {integer1}");
            Console.WriteLine($"String: {string1}");
            Console.WriteLine($"Float: {float1}");
            Console.WriteLine($"Double: {double1}");
            Console.WriteLine($"Boolean: {bool1}");


            // if condition
            Console.WriteLine("\n--If Statement--");
            int votingAeg = 18;

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((userAge >= votingAeg)
                ? "You are eligible for voting."
                : "Sorry, You are not eligible for voting!");


            // nested for loop
            Console.WriteLine("\n--Nested for loop--");
            Console.WriteLine("Demo of 'Nested FOR LOOP'");
            for (int outer = 1; outer <= 3; outer++)
            {
                Console.WriteLine($"Outer: {outer}");
                for (int inner = 1; inner <= 5; inner++)
                {
                    Console.WriteLine($" Inner: {inner}");
                }
            }


            // array sorting
            Console.WriteLine("\n--Array Sorting--");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Before Sorting");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Array.Sort(cars);
            Console.WriteLine("After Sorting");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


            // static method
            Console.WriteLine("\n--Static Method Demo--");
            static void MyName(string name, int age)
            {
                Console.WriteLine($"Name: {name}\nAge: {age}");
            }
            MyName("Parthiv", 21);
            MyName(age: 21, name: "Parthiv"); // Named Argument (prevents from order of arguments)


            // method overloading
            Console.WriteLine("\n--Method Overloading Demo--");
            Console.WriteLine($"Addition of integer: {addition(3, 2)}");
            Console.WriteLine($"Addition of float: {addition(3.21, 2.26)}");

            var book = new Grades();
            Console.WriteLine("Student's Grades are:");
            book.AddGrades(78.5);
            book.AddGrades(34.80);
            // book.grades.Add(32.56); // access modifier of grades List is default so it can't be accessed from another class
            book.displayGrade();


            // implicitly typed variable must be initialized.
            // var demo;
            // demo = 10;


            // default value of datatypes
            int def = default;

            // verbatim string
            string verbatim = @"Hello \n Simform";


            // enum demo
            Console.WriteLine("\n--Enum--");
            Console.WriteLine(Days.Monday); // Monday
            Console.WriteLine((int)Days.Monday); // 0


            // anonymous type
            Console.WriteLine("\n--Anonymous Type--");
            var student = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            Console.WriteLine(student.ToString());

            // dynamic type
            Console.WriteLine("\n--Dynamic Type--");
            dynamic dynamicVar = 34.2F;
            Console.WriteLine(dynamicVar.GetType());


            // instance of generic class
            Console.WriteLine("\n--Generic Class--");
            Gen<int> myGen = new Gen<int>();
            myGen.id = 23;
            Console.WriteLine(myGen.id);

            Gen<string> myStrGen = new Gen<string>();
            myStrGen.id = "24";


            // List<> Collection
            Console.WriteLine("\n--List<> Collection--");
            var employee = new List<int>
            {
                11,25,32,47,59
            };
            // Console.WriteLine(employee[7]);
            Console.WriteLine(employee[1]);

            // Dictionary and Hashtable
            Console.WriteLine("\n--Dictionary & Hashtable--");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            // dict[2] = "four";

            Hashtable ht = new Hashtable(dict);
            foreach(DictionaryEntry htEle in ht)
            {
                Console.WriteLine($"Key: {htEle.Key}, Value: {htEle.Value}");
            }


            // Stack
            Console.WriteLine("\n--Stack--");
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine("Stack:");
            foreach (var ele in myStack)
            {
                Console.Write($"{ele}, ");
            }

            Console.WriteLine("\n--Value Tuple(multiple return)--");
            static (int, string, string) GetPerson()
            {
                Console.Write("Enter Age:");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Fname:");
                var fname = Console.ReadLine();
                Console.Write("Enter Lname:");
                var lname = Console.ReadLine();
                return (age, fname, lname);
            }
            Console.WriteLine(GetPerson());

        }
        // Value Tuple
        static (int, string, string) GetPerson()
        {
            Console.WriteLine("Enter Age:");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fname:");
            var fname = Console.ReadLine();
            Console.Write("Enter Lname:");
            var lname = Console.ReadLine();
            return (age, fname, lname);
        }

        static int addition(int x, int y)
        {
            return x + y;
        }

        static double addition(double x, double y)
        {
            return x + y;
        }

        // structure
        struct Strct
        {
            public int x1;
            // constructor
            public Strct(int x1)
            {
                this.x1 = x1;
            }
        }

        // enum
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Sunday
        }

    }

    // inherit class and make child class static
    //class A
    //{
    //    public int x;
    //    public A(int x)
    //    {
    //        this.x = x;
    //    }

    //    A a = new A(1);
    //}
    //static class B: A
    //{
    //    public static void printMsg()
    //    {
    //        Console.WriteLine(a.x);
    //    }   
    //}



    // generic class
    class Gen<T>
    {
        public T id;
    }


    // trying to inherit multiple classes using partial class (gives error)
    //class A
    //{
    //    protected int a1 { get; set; }

    //}
    //class B
    //{
    //    public int b1 { get; set; }
    //}
    //partial class C: A
    //{
    //    C c0 = new C();
    //    c0.a1 = 1;
    //}
    //partial class C1: B
    //{
    //    static void Main(string[] args)
    //    {
    //        C c = new C();
    //        c.a2 = 23;

    //    }
    //}



}
