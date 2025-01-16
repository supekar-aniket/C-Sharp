namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Random random =  new Random();

        int num1 = random.Next(1,5); // 1 to 4
        double num2 = random.NextDouble();

        System.Console.WriteLine(num1);
        System.Console.WriteLine(num2);
    }
}