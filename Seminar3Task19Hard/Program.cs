﻿// Задача 19. НАпишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
// решение со звездочкой через dictionary для четырехзначных чисел
Dictionary<int, string> dict = new Dictionary<int, string>()
{
  [1111] = "палинндром",
  [1221] = "палинндром",
  [1331] = "палинндром",
  [1441] = "палинндром",
  [1551] = "палинндром",
  [1661] = "палинндром",
  [1771] = "палинндром",
  [1881] = "палинндром",
  [1991] = "палинндром",
  [2112] = "палинндром",
  [2222] = "палинндром",
  [2332] = "палинндром",
  [2442] = "палинндром",
  [2552] = "палинндром",
  [2662] = "палинндром",
  [2772] = "палинндром",
  [2882] = "палинндром",
  [2992] = "палинндром",
  [3113] = "палинндром",
  [3223] = "палинндром",
  [3333] = "палинндром",
  [3443] = "палинндром",
  [3553] = "палинндром",
  [3663] = "палинндром",
  [3773] = "палинндром",
  [3883] = "палинндром",
  [3993] = "палинндром",
  [4114] = "палинндром",
  [4224] = "палинндром",
  [4334] = "палинндром",
  [4444] = "палинндром",
  [4554] = "палинндром",
  [4664] = "палинндром",
  [4774] = "палинндром",
  [4884] = "палинндром",
  [4994] = "палинндром",
  [5115] = "палинндром",
  [5225] = "палинндром",
  [5335] = "палинндром",
  [5445] = "палинндром",
  [5555] = "палинндром",
  [5665] = "палинндром",
  [5775] = "палинндром",
  [5885] = "палинндром",
  [5995] = "палинндром",
  [6116] = "палинндром",
  [6226] = "палинндром",
  [6336] = "палинндром",
  [6446] = "палинндром",
  [6556] = "палинндром",
  [6666] = "палинндром",
  [6776] = "палинндром",
  [6886] = "палинндром",
  [6996] = "палинндром",
  [7117] = "палинндром",
  [7227] = "палинндром",
  [7337] = "палинндром",
  [7447] = "палинндром",
  [7557] = "палинндром",
  [7667] = "палинндром",
  [7777] = "палинндром",
  [7887] = "палинндром",
  [7997] = "палинндром",
  [8118] = "палинндром",
  [8228] = "палинндром",
  [8338] = "палинндром",
  [8448] = "палинндром",
  [8558] = "палинндром",
  [8668] = "палинндром",
  [8778] = "палинндром",
  [8888] = "палинндром",
  [8998] = "палинндром",
  [9119] = "палинндром",
  [9229] = "палинндром",
  [9339] = "палинндром",
  [9449] = "палинндром",
  [9559] = "палинндром",
  [9669] = "палинндром",
  [9779] = "палинндром",
  [9889] = "палинндром",
  [9999] = "палинндром",
};
// Просим ввести число
Console.WriteLine("Введите  четырехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");// проверяем на null safety
// проверяем является ли наше число четырехзначным
// и входит ли введеное нами число в словарь
if (num > 999 && num < 10000)
{
  if (dict.ContainsKey(num))

  {
    Console.WriteLine(dict[num]);
  }
  else
  {
    Console.WriteLine("Не является палиндромом");
  }
}
else
{
  Console.WriteLine("Вы ввели не четырехзначное число!");
}

