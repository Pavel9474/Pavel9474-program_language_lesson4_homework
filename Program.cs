// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
         arr[i] = new Random().Next(-100,100);
         if (i==0)
         {
            Console.Write("[" + arr[0] + ", ");
         }
         else if (i==arr.Length-1)
         {
            Console.Write(arr[arr.Length-1] + "]");
         }
         else 
         {
            Console.Write(arr[i] + ", ");  
         }
         
    }
}
int[] array = new int[8];
PrintArray(array);