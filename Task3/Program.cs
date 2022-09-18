// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
static int akkerman(int num1, int num2)
{
  if (num1 == 0) return num2 + 1;
  else
  {
    if ((num1 != 0) && (num2 == 0)) return akkerman(num1 - 1, 1);
    else return akkerman(num1 - 1, akkerman(num1, num2 - 1));
  }
}
Console.Write(akkerman(m, n));