// задача 28. напишите программу, которая на вход принмает число n
// и выдает произведение чисел от 1 до n
using System.Numerics;// позволяет использовать больший тип данных
// например BigInteger
// вводится в начале кода для подключения доп ядра
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, BigInteger res)
{
  Console.WriteLine(msg+res);
}
BigInteger factorial1 (int num) // если вводим слишком большое число - пользуемся типом данных long
{
  BigInteger res = 1;
  for (int i = 2; i <= num; i++)// начинаем с двойки, тк у нас произведение
  {
    res=res*i;
  }
    return res;
}
int numberA = ReadData("Введите число А:");
BigInteger res1 = factorial1(numberA);
PrintData ("Произведение чисел от 1 до А = ", res1);