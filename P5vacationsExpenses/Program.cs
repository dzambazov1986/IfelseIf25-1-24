string season = Console.ReadLine();
string accommodationType = Console.ReadLine();  
int countOfTheDays = int.Parse(Console.ReadLine());

if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        double pricePerNight = 30;
        double discount = 0.20;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);

        Console.WriteLine($"{total:F2}");
    }
    else if (accommodationType == "Camping")
    {
        double pricePerNight = 10;
        double discount = 0.20;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);
        Console.WriteLine($"{total:F2}");
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        double pricePerNight = 50;
        double total = pricePerNight * countOfTheDays;
        Console.WriteLine($"{total:F2}");
    }
    else if (accommodationType == "Camping")
    {
        double pricePerNight = 30;
        double total = pricePerNight * countOfTheDays;
        Console.WriteLine($"{total:F2}");
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        double pricePerNight = 20;
        double discount = 0.30;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);
        Console.WriteLine($"{total:F2}");
    }
    else if (accommodationType == "Camping")
    {
        double pricePerNight = 15;
        double discount = 0.30;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);
        Console.WriteLine($"{total:F2}");
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        double pricePerNight = 40;
        double discount = 0.10;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);
        Console.WriteLine($"{total:F2}");
    }
    else if (accommodationType == "Camping")
    {
        double pricePerNight = 10;
        double discount = 0.10;
        double total = countOfTheDays * pricePerNight - (countOfTheDays * pricePerNight * discount);
        Console.WriteLine($"{total:F2}");
 }
}