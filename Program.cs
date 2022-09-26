// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
int GetNumber(string name)
{
    Console.WriteLine("Введите число " + name);
    return Convert.ToInt32(Console.ReadLine());
}
int GetPow(int A, int B)
{
int result = 1;
for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
return result;
}   
int A = GetNumber("A");
int B = GetNumber("B");
Console.WriteLine(GetPow(A, B));