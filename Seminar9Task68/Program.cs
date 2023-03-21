// Напишите программу вычисления функции Аккермана с помощью рекурсиию
// даны 2 неотрицательных числа m и n.
static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
uint ReadData(string msg)
{
  Console.WriteLine(msg);
  return uint.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

uint numM = ReadData("Введите  m: ");
uint numN = ReadData("Введите  n: ");
PrintData($"Функция Аккермана для чисел m и n = {Akk(numM,numN)}");
