

int number = Random.Shared.Next(10,100);
Console.WriteLine(number);
int LastDigit = number % 10;
int FirstDigit = number / 10;
if (FirstDigit > LastDigit)
{
    Console.WriteLine($"max{FirstDigit} min{LastDigit}");
}
else 
{
    Console.WriteLine($"min {FirstDigit}, max {LastDigit}");
}