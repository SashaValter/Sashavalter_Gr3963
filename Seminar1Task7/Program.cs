// Задача 7. Напишите программу, которая на вход принимает 3-х значное число
// и на выходе показывает последнюю цифру этого числа


Console.WriteLine("Введите число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
// "!=" - не равно ...
{
  int inputNumber = int.Parse(inputLine);
  int res = inputNumber % 10;
  // % - отстаток от деления 
  Console.WriteLine ("последняя цифра " + res);
}