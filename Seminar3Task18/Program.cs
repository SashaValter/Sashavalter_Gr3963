// Задача 18. Напишите программу, которая по заданному номеру четверти
// координатной плоскости выдает диапазон значений для этой плоскости
//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// метод показывает значения x,y для введенного номера четверти
void PrintDiapTest(int quter)
{
  if (quter > 0 && quter < 5)
  {
    if (quter == 1) Console.WriteLine("x>0,y>0");
    if (quter == 2) Console.WriteLine("x>0,y<0");
    if (quter == 3) Console.WriteLine("x<0,y<0");
    if (quter == 4) Console.WriteLine("x<0,y>0");
  }
  else
  {
    Console.WriteLine("Вы ввели не номер четверти!");
  }
}
int quter = ReadData("Введите  номер четверти(1-4): ");
PrintDiapTest(quter);