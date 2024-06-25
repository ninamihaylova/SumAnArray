class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;
        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }

        Console.WriteLine(sum);
    }
}


