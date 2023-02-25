// Задача 19. НАпишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// напишем метод, который устанавливает является ли пятизначное число палиндромом
bool PalinTest(int num);//bool - тип данных который показывает удовлетворяет ли заданное значение нашему условию
{
  if (num < 10000 && num > 100000)
  {
    Console.WriteLine("Вы ввели не пятизначное число");
  }
  else
  {
    bool res = false;
    if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 1))
    {
      res = true;
    }
    return res;
    if (res = true)
    {
      Console.WriteLine("Число является палиндромом");
    }
    else
    {
      Console.WriteLine("Число не является палиндромом");
    }
  }
}
int num1 = ReadData("Введите пятизначное число: ");
PalinTest(num1);
