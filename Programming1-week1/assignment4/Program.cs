namespace assignment4;

class Program
{
    static void Main(string[] args)
    {
        //read a number
        Console.Write("entre a number :");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        //assign variable 'result' the result of 'number + number'
        int result = number + number;

        //add 10 to result
        result = result + 10;

        //divide result by 2
        result = result / 2;

        //subtract original number from result
        result = result - number ;

        Console.WriteLine($"result is :{result}");
    }
}

