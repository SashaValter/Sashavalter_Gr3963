// Задача 26. Напишите программу, которая принимает на вход число,
// а на выходе показывает количество цифр в этом
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}


int num = ReadData("Введите число: ");
PrintData($"Количество цифр в числе - {num.ToString().Length}");
// num.ToString().Length - метод конвертации числа в строку и одновременно измеряет длинну строки