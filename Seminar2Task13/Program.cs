﻿// Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет
// Вводим переменные
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999)//проверяем что бы длина была больше 2
{
  //Узнаём на какое количество десятков нужно укоротить наше число
  while (num > 999)
  {
    num /= 10;
  }
  //уменьшаем введёное число до 3 знаков и выводим
  Console.WriteLine($"Третья цифра заданного числа = {num % 10}");
}
else
{ // Выводим сообщение об ошибке и просим пользователя повторно ввести данные
  Console.WriteLine("Третьей цифры нет" +
                          "\nПопробуйте ещё раз");
  Console.WriteLine("\n\nНажмите любую кнопку для продолжения");
  Console.ReadKey();
}

