
using System.ComponentModel.Design;

int year;
void LeapYearChecker()
{

    Console.WriteLine("Enter a year");
    year = Convert.ToInt32(Console.ReadLine());



    if ( year % 4 == 0 || year % 400 == 0 ) {

        Console.WriteLine($"{year} is a leap year");

    } else if ( year > 0 )
    {
        Console.WriteLine($"{year} is not a leap year");
    } else
    {
        Console.WriteLine("Invalid input");
    }

}

LeapYearChecker();