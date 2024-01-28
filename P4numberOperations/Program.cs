double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine()); 
string mathOperator = Console.ReadLine();


if (mathOperator == "+")
{ 
    double sum = num1 + num2;
    Console.WriteLine($"{num1} {mathOperator} {num2} = {sum:F2}");
}
else if (mathOperator == "-")
{
    double sum = num1 - num2;
    Console.WriteLine($"{num1} {mathOperator} {num2} = {sum:F2}");

}
else if (mathOperator == "*")
{
    double sum = (num1 * num2);
    Console.WriteLine($"{num1} {mathOperator} {num2} = {sum:F2}");
}
else if (mathOperator == "/")
{
    double sum = (num1 / num2);
          Console.WriteLine($"{num1} {mathOperator} {num2} = {sum:F2}");

}