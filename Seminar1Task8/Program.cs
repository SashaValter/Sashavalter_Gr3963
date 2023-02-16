// Задача 8. Напишите программу, которая на вход принимает число n,
// а на выходе показывает все ЧЕТНЫЕ числа от 1 до  n
Console.WriteLine("Введите число: ");
var numN = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= numN; i = i + 2)
{
  Console.Write(i + "\t");
}