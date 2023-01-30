// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
int n = 4; 
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];

for (int i = 0; i < arr.GetLength(0); i++)
 {
    for (int j = 0; j < arr.GetLength(1); j++)
     {
       arr[i, j] = random.Next(1, 10);
       Console.Write("{0} ", arr[i, j]);
     }
 Console.WriteLine();
 }
    
if (pos1 < 0 | pos1 > arr.GetLength(0) | pos2 < 0 | pos2 > arr.GetLength(1))
    {
      Console.WriteLine("Элемент не существует  ");
    }
else
    {
      Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    }
Console.ReadLine();