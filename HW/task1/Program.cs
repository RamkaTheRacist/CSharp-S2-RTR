//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Which day of week?");
int number = int.Parse(Console.ReadLine());
if(number < 6 && number > 0)
{
    Console.WriteLine("This day isnt weekend");

}
else if(number == 6 || number == 7)
{
    Console.WriteLine("This day is weekend");
}
else
{
    
    Console.WriteLine("We have only 7 days in week");
}