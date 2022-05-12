//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("X?");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Y?");
int y = int.Parse(Console.ReadLine());
if(x > 0)
{
    if(y > 0)
    {
        Console.WriteLine("Plane is 2");
    }
    else
    {
        Console.WriteLine("Plane is 4");
    }
}
else
{
    if(y > 0)
    {
        Console.WriteLine("Plane is 1");
    }
    else
    {
        Console.WriteLine("Plane is 3");
    }
}