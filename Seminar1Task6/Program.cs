// Задача 6. НАпишите программу, которая на вход принимает число и определяет
// является ли оно четным

Console.WriteLine("Введите число: ");
var num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
  Console.WriteLine ("Да, является!");
}
else
{
  Console.WriteLine ("Нет, не является!");
}