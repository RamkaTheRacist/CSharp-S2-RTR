//Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Which measurement 2D or 3D?");
string measurement = Console.ReadLine();
if(measurement.ToLower() == "2d" || measurement == "2")
{
    Console.WriteLine("X of first point?");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Y of first point?");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("X of second point?");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Y of second point?");
    double y2 = double.Parse(Console.ReadLine());
    double tmpx = 0;
    double tmpy = 0;
    if(x1 < 0 && x2 < 0)
    {
        if(Math.Abs(x1) > Math.Abs(x2))
        {
            tmpx = Math.Abs(x1) - Math.Abs(x2);
        }
        else
        {
            tmpx = Math.Abs(x2) - Math.Abs(x1);
        }      
    }
    else
    {
        if(x1 > x2)
        {
            tmpx = x1 - x2;
        }
        else
        {
            tmpx = x2 - x1;
        }      
    }
    if(y1 < 0 && y2 < 0)
    {
        if(Math.Abs(y1) > Math.Abs(y2))
        {
            tmpy = Math.Abs(y1) - Math.Abs(y2);
        }
        else
        {
            tmpy = Math.Abs(y2) - Math.Abs(y1);
        }      
    }
    else
    {
        if(y1 > y2)
        {
            tmpy = y1 - y2;
        }
        else
        {
            tmpy = y2 - y1;
        }      
    }
    double distance = Math.Sqrt(Math.Pow(tmpx, 2) + Math.Pow(tmpy, 2));
    Console.WriteLine($"Distance between first point and second point is {distance}");
}
else if(measurement.ToLower() == "3d" || measurement == "3")
{
    Console.WriteLine("X of first point?");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Y of first point?");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Z of first point?");
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("X of second point?");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Y of second point?");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Z of second point?");
    double z2 = double.Parse(Console.ReadLine());
    double tmpx = 0;
    double tmpy = 0;
    double tmpz = 0;
    if(x1 < 0 && x2 < 0)
    {
        if(Math.Abs(x1) > Math.Abs(x2))
        {
            tmpx = Math.Abs(x1) - Math.Abs(x2);
        }
        else
        {
            tmpx = Math.Abs(x2) - Math.Abs(x1);
        }      
    }
    else
    {
        if(x1 > x2)
        {
            tmpx = x1 - x2;
        }
        else
        {
            tmpx = x2 - x1;
        }      
    }
    if(y1 < 0 && y2 < 0)
    {
        if(Math.Abs(y1) > Math.Abs(y2))
        {
            tmpy = Math.Abs(y1) - Math.Abs(y2);
        }
        else
        {
            tmpy = Math.Abs(y2) - Math.Abs(y1);
        }      
    }
    else
    {
        if(y1 > y2)
        {
            tmpy = y1 - y2;
        }
        else
        {
            tmpy = y2 - y1;
        }      
    }
    if(z1 < 0 && z2 < 0)
    {
        if(Math.Abs(z1) > Math.Abs(z2))
        {
            tmpz = Math.Abs(z1) - Math.Abs(z2);
        }
        else
        {
            tmpz = Math.Abs(z2) - Math.Abs(z1);
        }      
    }
    else
    {
        if(z1 > z2)
        {
            tmpz = z1 - z2;
        }
        else
        {
            tmpz = z2 - z1;
        }      
    }
    double distance = Math.Sqrt(Math.Pow(tmpx, 2) + Math.Pow(tmpy, 2) + Math.Pow(tmpz, 2));
    Console.WriteLine($"Distance between first point and second point is {distance}");
}
else
{
    Console.WriteLine("Stop to wasting my time -_-");
}