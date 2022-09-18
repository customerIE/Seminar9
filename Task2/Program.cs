// Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
int[,] array = new int[4,4];
int count=0;
int index = 0;
int number=1;
while (count < 16)
{
    index++;
    for (int i=index-1; i<4-index+1; i++)
    {
        array[index-1,i] = number++;
        count++;
    }  
    for (int i=index; i<4-index+1; i++)
    {
        array[i,4-index] = number++;
        count++;
    }   
    for (int i=4-index-1; i>=index-1; i--)
    {
        array[4-index,i] = number++;
        count++;
    }   
    for (int i=4-index-1;i>=index; i--)
    {
        array[i,index-1] = number++;
        count++;
    }  
}
for(int i=0; i<4; i++)
{
    for(int j=0; j<4; j++)
    {
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine();
}




