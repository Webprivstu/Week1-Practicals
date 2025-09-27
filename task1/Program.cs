using System.Runtime.InteropServices.Marshalling;

void AgeFigureOuter() {

int age;

Console.WriteLine("What is your age?");

age = Convert.ToInt32(Console.ReadLine());

    if (age > 19 && age < 110) {

    Console.WriteLine("You are an adult");

    }
    else if (age > 0 && age < 13) {
        Console.WriteLine("You are a child");

    } else if ((age <= 19) && (age <= 13) && (age !=0))
    {
        Console.WriteLine("You are a teenager");
    } else 
    {
        Console.WriteLine("Invalid option - either you don't exist or your are dead. Sorry!");
    }

}

AgeFigureOuter();