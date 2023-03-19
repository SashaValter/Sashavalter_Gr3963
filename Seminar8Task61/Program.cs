// задача 61. выведите первые n-строк треугольника Паскаля,
// сделать вывод в виде равнобедренного треугольника
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// n!/k!*(n-k)! - формула для вычисления конкретного элемента треугольника
long Factoreal(int n)
{
  long res = 1;
  for (int i = 1; i <= n; i++)
  {
    res = res * i;
  }
  return res;
}
//          1
//         1 1
//        1 1 1
void PrintPascalTriangle(int nRow)
{
  for (int i = 0; i < nRow; i++)
  {
    for (int k=0; k<nRow-i; k++)
    {
      Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
      Console.Write(" ");
      Console.Write(Factoreal(i)/(Factoreal(j)*Factoreal(i-j)));
    }
    Console.WriteLine();
  }
}
int countRow = ReadData("Введите количество строк труегольника Паскаля");
PrintPascalTriangle(countRow);