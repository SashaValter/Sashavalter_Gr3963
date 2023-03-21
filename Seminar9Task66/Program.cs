// задача 66. задайте два числа m и n, напишите программу, которая
// посчитает сумму натуральных чисел в промежутке от m до n
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
int RecSumDigMN(int m, int n)
{
  if (m >= n)
  {
    return n;
  }
  else
  {
    return m + RecSumDigMN(m + 1, n);
  }
}
int numM = ReadData("Введите  M: ");
int numN = ReadData("Введите  N: ");
int numSum = numM < numN ? RecSumDigMN(numM, numN) : RecSumDigMN(numN, numM);
PrintData($"Сумма чисел в данном промежутке = {numSum}");