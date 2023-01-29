// Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.WriteLine($"Укажите размерность матрицы");
int SizeOfMatrix = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[SizeOfMatrix, SizeOfMatrix];

int temp = 1;
int x = 0;
int y = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[x, y] = temp;
  temp++;

  if (x <= y + 1 && x + y < Matrix.GetLength(1) - 1) y++;
  else if (x < y && x + y >= Matrix.GetLength(0) - 1) x++;
  else if (x >= y && x + y > Matrix.GetLength(1) - 1) y--;
  else x--;
}

for (int i = 0; i < Matrix.GetLength(0); i++)
    {
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        if (Matrix[i, j] < 10)
        {
            Console.Write($" 0{Matrix[i, j]} ");      
        }
        else
        {
            Console.Write($" {Matrix[i, j]} ");
        }
    }
    Console.WriteLine();
}
