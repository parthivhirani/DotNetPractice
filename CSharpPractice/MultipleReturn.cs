public class MultipleReturn
{
    static IEnumerable<int> GetUserInput()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter Number {i}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            yield return number;
        }
    }
    static void Main(string[] args)
    {
        int[] a = new int[5];
        int i = 0;
        foreach (int val in GetUserInput())
        {
            a[i] = val;
            Console.WriteLine($"Your input is {a[i]}");
            i++;
        }
    }

}