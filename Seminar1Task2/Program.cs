// Задача 2. Напишите программу, которая на вход принимает 2 числа
// и выдает: какое число больше, а какое меньше
Console.WriteLine("Введите число №1: ");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите число №2: ");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  if (num1 > num2)
  {
    Console.WriteLine("Число 1 больше числа 2");
  }
  else
  {
    Console.WriteLine("Число 2 больше числа 1");
  }
}
