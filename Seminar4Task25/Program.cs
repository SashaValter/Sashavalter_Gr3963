// Задача 25. Напишите цикл, который принимает два числа А и В
// и возводит число А в натуральную степень В
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, long res)
{
  Console.WriteLine(msg + res);
}
long methodPow(int a, int b)
{
  long res = 1;
  while (b > 0)
  {
    res = res * a;
    b = b - 1;// здесь мы умножаем степень на единицу
  }
  return res;

}
int numberA = ReadData("Введите число А:");
int numberB = ReadData("Введите число B:");
long res = methodPow(numberA,numberB);
PrintData("Число А возведенное в натуральную степень числа В =", res);
