int number;

void Checker()
{

    Console.WriteLine("Enter an integer");
    number = Convert.ToInt32(Console.ReadLine());

    if (number < 0) {

        Console.WriteLine("Your number is negative");

    }
    else if (number >= 0) {

        Console.WriteLine("Your number is positive");
    }


}

Checker();