namespace CSharpPractice.PartialDemo
{
    public partial class Employee
    {
        public string name;
        public int age;
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;

        }
        partial void printEmployee();
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Parthiv", 21);
            emp1.printEmployee();

        }
    }
}
