// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
Console.Write("Введите кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во сттолбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];
Random rnd = new Random();
Console.WriteLine("Случайно сгенерированный массив:");
for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array[i,j] = rnd.Next(1, 50);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
}
for(int i=0; i<rows; i++)
{   
    int max = array[i,0];
    for(int j=1; j<columns; j++)
    {
        for(int k=1; k<columns; k++)
        {
        if(array[i,k-1]<array[i,k])
        {
            int temp = array[i,k-1];
            array[i,k-1] = array[i,k];
            array[i,k] = temp;
        }
        }
    }
}
Console.WriteLine("Массив отсортированный по убыванию строк:");
for (int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
}