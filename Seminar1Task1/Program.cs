// Задание 1. Проверить, является ли число 2 квадратом числа 1
Console.WriteLine("Введите число №1: ");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите число №2: ");
string? numLine2 = Console.ReadLine();

// проверяем 2 числа на null safety. && - знак того что оба выражения true
// != - "не равно"

if (numLine1 != null && numLine2 != null)
{
  // convert to int
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  if (num2 * num2 == num1)
  // if (num1 == (int)Math.Pow(num2,2)) - из 0 задания
  {
    Console.WriteLine("ДА!");
  }
   else 
   {
    Console.WriteLine ("Нет!");
   }
}