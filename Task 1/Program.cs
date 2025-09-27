
string name;
int age;

Console.WriteLine("Please enter your name");

name = Console.ReadLine();

Console.WriteLine("Enter your age");

age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hello {name}, you will be {(age + 5)} in five years ");
