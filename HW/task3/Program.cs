//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Which plane?");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("On first plane: any x < 0 and any y > 0");
}
else if(number == 2)
{
    Console.WriteLine("On second plane: any x > 0 and any y > 0");
}
else if(number == 3)
{
    Console.WriteLine("On third plane: any x < 0 and any y < 0");
}
else if(number == 4)
{
    Console.WriteLine("On fourth plane: any x > 0 and any y < 0");
}
else
{
    Console.WriteLine("???");
}

