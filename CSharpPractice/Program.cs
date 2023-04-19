using System.Security.Cryptography.X509Certificates;

namespace CSharpPractice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // types of variable
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
            int votingAeg = 18;

            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((userAge >= votingAeg)
                ? "You are eligible for voting."
                : "Sorry, You are not eligible for voting!");


            // nested for loop
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
            static void MyName(string name, int age)
            {
                Console.WriteLine($"Name: {name}\nAge: {age}");
            }
            MyName("Parthiv", 21);
            MyName(age: 21, name: "Parthiv"); // Named Argument (prevents from order of arguments)


            // method overloading
            Console.WriteLine(addition(3, 2));
            Console.WriteLine(addition(3.21, 2.26));

            var book = new Grades();
            Console.WriteLine("Student's Grades are:");
            book.AddGrades(78.5);
            book.AddGrades(34.80);
            // book.grades.Add(32.56); // access modifier of grades List is default so it can't be accessed from another class
            book.displayGrade();
        }
        static int addition(int x, int y)
        {
            return x + y;
        }

        static double addition(double x, double y)
        {
            return x + y;
        }
    }
}
