// задача 63. задайте значение n. напишите программу, которая выведет
// все числа от n до 1, используя рекурсию.
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void LineGenRec(int num)
{
  Console.Write(num+ " ");
  if (num == 1)
  {
  }
  else
  {
    LineGenRec(num - 1);// каждый следующий вызов, входные параметры будут меняться на -1              
  }
}
int numer = ReadData("Введите число N: ");
LineGenRec(numer);