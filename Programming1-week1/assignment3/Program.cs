namespace assignment3;

class Program
{
    static void Main(string[] args)
    {
        //read first name of user
        Console.WriteLine("Entre you first name :");
        string firstName = Console.ReadLine();

        //read the last name of user
        Console.WriteLine("entre your last name :");
        string lastName = Console.ReadLine();

        //display full name (option 1)
        Console.WriteLine("Your full name is "+firstName+" "+lastName);

        //display full name (option 2)
        Console.WriteLine("Your full name is {1} {0}",firstName,lastName);

        //display full anem(option 3 - string interpolation)
        Console.WriteLine($"Your full name is {firstName} {lastName}");

        //wait for the user enter a key
        Console.ReadKey();
    }
}

