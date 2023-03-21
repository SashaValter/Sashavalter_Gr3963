// задача 64. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N, при помощи рекурсии
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void LineGenRec(int num)
{
  Console.Write(num + " ");
  if (num <= 1)
  {
  }
  else
  {
    LineGenRec(num - 1);// каждый следующий вызов, входные параметры будут меняться на -1              
  }
}
int number = ReadData("Введите число N: ");
LineGenRec(number);