//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("First number?");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second number?");
int number2 = int.Parse(Console.ReadLine());
if(number1 * number1 == number2)
{
    Console.WriteLine($"Second number({number2}) is square of first({number1})");
}
else if(number2 * number2 == number1)
{
    Console.WriteLine($"First number({number1}) is square of second({number2})");
}
else
{
    Console.WriteLine($"First number({number1}) isnt square of second({number2}) and second number({number2}) isnt square of first({number1})");
}