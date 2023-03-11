// задача 40. напишите программу, которая на вход принимает 3 числа и проверяет
// может ли существовать треугольник со сторонами такой длинны
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
bool Test(int a, int b, int c)// пишем вспомогательный метод, который укоротит нам запись равенства сторон треугольника
{
  return (a <= b + c);
}
bool TriangleTest(int a, int b, int c)
{
  bool res = false;
  if (Test(a, b, c) && Test(b, a, c) && Test(c, a, b))// в проверке условия обращаемся к вспомогательному методу
  {
    res = true;
  }
  return res;
}
void TriangleCheck(int a, int b, int c)
{
  if (a <= b + c && b <= a + c)
  {
    if (c <= a + b)
    {
      Console.WriteLine("Треугольник со сторонами такой длинны может существовать!");
    }
    else
    {
      Console.WriteLine("Треугольник со сторонами такой длинны существовать не может!");
    }
  }
  else
  {
    Console.WriteLine("Треугольник со сторонами такой длинны существовать не может!");
  }
}
int a = ReadData("Введите a:");
int b = ReadData("Введите b:");
int c = ReadData("Введите c:");
//TriangleCheck(a, b, c);
PrintData($"Треугольник с этими сторонами может существовать - {TriangleTest(a, b, c)}");