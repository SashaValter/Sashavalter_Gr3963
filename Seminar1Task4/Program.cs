// Задача 4. Напишите программу, которая на вход принимает 3 числа
// и выдает максимальное из этих чисел
Console.WriteLine("Введите число №1: ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3: ");
var num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
  Console.WriteLine("Наибольшее число: " + num1);
}
if (num2 > num1 && num2 > num3)
{
  Console.WriteLine("Наибольшее число: " + num2);
}
if (num3 > num1 && num3 > num2)
{
  Console.WriteLine("Наибольшее число: " + num3);
}

// попробовал использовать Math.Max, но почему то не дает сравнить 3 числа
// (сравнивает лишь 2)
//int outNum = (int)Math.Max(num1, num2, num3);
//Console.WriteLine("Наибольшее число: " + outNum);