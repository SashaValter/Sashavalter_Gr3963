// задача 42. введите число в десятичной системе счисления
// и перевести его в двоичную
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
string DeckToBin (int num)// метод преобразования типа из 10чного в 2чный
{
  string res= string.Empty;// заказываем строку, присваеваем ей пустое значение
  while(num>0)
  {
    res=num%2+res;// накапливаем в строку остатки от деления на 2
    num=num/2;// здесь num делим на 2 до тех пор, пока num>0
  }
  return res;
}
string DeckToBinExtra (int num, int baseI)// встроенный универсальный метод. Можно ковертировать число в любую систему счисления
{
  return Convert.ToString(num, baseI);
}
int num = ReadData("Введите число в десятичной системе счисления: ");
int baseI = ReadData("Введите систему счисления");
PrintData($"Версия числа в новой системе счисления - {DeckToBinExtra(num,baseI)}");