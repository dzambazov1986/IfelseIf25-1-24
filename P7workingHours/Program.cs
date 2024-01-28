int hourOfDay = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
{
    if (hourOfDay >= 10 && hourOfDay <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }
}
else
{
    Console.WriteLine("closed");
}
