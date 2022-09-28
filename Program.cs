// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetNumber()
{
    
    Console.WriteLine("Введите число!");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}  
int SumNumber(int num)
{
int sum = 0;
while (num != 0)
{
    sum = sum + num % 10;
    num = num /10;
}
return sum;
}
int num = GetNumber();
Console.WriteLine("Сумма цифр равна " + SumNumber(num));