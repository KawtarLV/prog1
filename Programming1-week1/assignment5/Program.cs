namespace assignment5;

class Program
{
    static void Main(string[] args)
    {
        Random rnd1 = new Random();
        int number1 = rnd1.Next(101, 10000);

        Random rnd2 = new Random();
        int number2 = rnd2.Next(101, 10000);

        Random rnd3 = new Random();
        int number3 = rnd3.Next(101, 10000);

        Random rnd4 = new Random();
        int number4 = rnd4.Next(101, 10000);
        
        int result = number1 + number2 + number3 + number4;

        Console.Write(number1+"+"+ number2 + "+" + number3 + "+" + number4 + "=" +result);
    }
}

