// задача 43. напишите программу , которая найдет пересечение двух прямых
// данных уравнением y=k1x+b1, y=k2x+b2
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
double countX(int k1, int b1, int k2, int b2)
{
  double x = (b2-b1)/(k1-k2);
  return x;
}
double countY (double x, int k1, int b1)
{
  double y = (k1*x)+b1;
  return y;
}
int k1 = ReadData ("Введите k1:");
int b1 = ReadData ("Введите b1:");
int k2 = ReadData ("Введите k2:");
int b2 = ReadData ("Введите b2:");
PrintData($"Пересечением двух прямых будет точка с координатами: ({countX(k1,b1,k2,b2)},{countY(countX(k1,b1,k2,b2),k1,b1)})");