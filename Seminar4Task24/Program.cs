// задача 24. напишите программу, которая принимает на вход число А и выдает
// сумму чисел от одного до А
// метод для чтения данных от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
long sumSimpleEasy (long numA) // если вводим слишком большое число - пользуемся типом данных long
{
  long sum = 0;
  for (int i = 1; i <= numA; i++)
  {
    sum+=i; // sum=sum+i; (в сокращенном виде)
  }
    return sum;
}
long sumGausse(long numB)
{
  long sum = 0;
  return sum = ((1 + numB) * numB) / 2;// пользуемся формулой Гаусса

}
long numberA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now;// эта переменная фиксирует время запуска программы
long res1 = sumSimpleEasy(numberA);
Console.WriteLine(DateTime.Now-d1);// здесь находим разницу(время работы метода) между текущим временем и временем запуска программы
DateTime d2 = DateTime.Now;
long res2 = sumGausse(numberA);
Console.WriteLine(DateTime.Now-d2);
PrintData("Сумма чисел от 1 до А равна: " + res1);
PrintData("Сумма чисел от 1 до B равна(методом Гаусса): " + res2);