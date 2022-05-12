//Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
if(number / 10000 == number % 10 && (number / 1000 % 10) == (number % 100 / 10))
{
    Console.WriteLine($"{number} является палиндромом");
}
else
{
    Console.WriteLine($"{number} не является палиндромом");
}