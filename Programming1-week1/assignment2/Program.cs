namespace assignment2;

class Program
{
    static void Main(string[] args)
    {
        //read oge of user
        Console.Write("Entre your age :");
        string input = Console.ReadLine();

        //convert text to integer
        int age = int.Parse(input);

        //increase age by 1
        age++;

        Console.WriteLine($"Next year you will be {age} years old.");


       

    }

}

