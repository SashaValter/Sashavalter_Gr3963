// задача 65. задайте значения m и n, напишите программу, которая
// найдет все натуральные элементы в промежутке от m до n
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
string LineGenRecMN(int m, int n)
{
  string res = string.Empty;
  if (m >= n)
  {
    res = n.ToString();
  }
  else
  {
    res = res + m + " " + LineGenRecMN(m + 1, n);
  }
  return res;
}
int M = ReadData("Введите  M: ");
int N = ReadData("Введите  N: ");
string resLine = M < N ? LineGenRecMN(M, N):LineGenRecMN(N,M);// используем тернарный оператор для защиты от дурака
PrintData(resLine);