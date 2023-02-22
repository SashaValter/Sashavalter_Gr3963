// Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет
Console.WriteLine("Введите  число ");
string num =int.Parse(Console.ReadLine() ?? "0");
if (num.length >= 3)
{
  char[] arr = num.ToCharArray();
  // превращаем число в массив цифр -> остается вывести значение с индексом 2
  // тк нумерация в массиве начинается с нуля!
  Console.WriteLine(arr[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

