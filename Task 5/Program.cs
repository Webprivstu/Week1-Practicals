int number;

void Checker()
{

    Console.WriteLine("Enter an integer");
    number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {

        Console.WriteLine("Your number is even");
    }
    else
    {
        Console.WriteLine("Your number is odd");

    }
}

Checker();