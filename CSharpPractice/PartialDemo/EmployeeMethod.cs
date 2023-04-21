namespace CSharpPractice.PartialDemo
{
    partial class Employee
    {

        partial void printEmployee()
        {
            Console.WriteLine($"Employee Name: {name}\nEmployee Age: {age}");
        }
    }
}
