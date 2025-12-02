Console.WriteLine("Enter a Number");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another number");
double Num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add, subtract, divide or multiply?");

char Symbol = Convert.ToChar(Console.ReadLine());

double Result = 0;

if (Symbol == '+')
{
    Result = Num1 + Num2;
}
if (Symbol == '-')
{
    Result = Num1 - Num2;
}
if (Symbol == '/')
{
    Result = Num1 / Num2; 
}
if (Symbol == '*')
{
    Result = Num1 * Num2; 
}

Console.WriteLine("The answer is:");
Console.WriteLine(Result);