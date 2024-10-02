namespace Test1;

class Program
{
    const double PRICELITRE = 2.2;

    static void Main(string[] args)
    {
       // Console.WriteLine("Hello, kaoutar!!!");

         // 1. read number of litres tanked
            Console.Write("Enter number of litres tanked:");
            string input = Console.ReadLine();


          // convert string to double (data type conversio
            double nrofLitres = double.Parse(input);


            // 2. calculate the amount
            double amount = nrofLitres * PRICELITRE;


            // 3. display the amount
            Console.WriteLine("The amount is: " + amount);
}
    
}


