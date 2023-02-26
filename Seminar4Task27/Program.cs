// Задача 27 Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, int res)
{
  Console.WriteLine(msg + res);
}
int SummInt(int num)
{
    int res = 0;

    while (num > 0)
    {
        res += num % 10;// res= res+num%10
        num /= 10;//num=num/10
    }

    return res;
}
// int SummString(int num)
// {
//     int res = 0;
//     string numString = Convert.ToString(num);
//     int len = numString.Length;

//     for (int i = 0; i < len; i++)
//     {
//         res = res + Convert.ToInt32(numString[i]-48);
//     }

//     return res;
// }
int numberA = ReadData("Введите число:");
int result = SummInt(numberA);
PrintData("Сумма цифр в числе =",result);