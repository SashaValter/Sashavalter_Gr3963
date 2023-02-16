// Задача 5. НАпишите программу, которая на вход принимает одно число n
// а на выходе показывает все целые числа от -n до n
Console.WriteLine("Введите число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
  //парсим введенное число
  int inputNumber = int.Parse(inputLine);
  int startNumber = inputNumber * (-1);
  // выходное значение
  string outLine = string.Empty;

  while (startNumber < inputNumber)
  {
    outLine = outLine + startNumber + ", ";
    startNumber++;
    // startNumber++ - то же самое что startNumber = startNumber+1
  }
  outLine = outLine + inputNumber;
  Console.WriteLine(outLine);
  
}

//Console.WriteLine("Введите число: ");
// var - любой тип данных для переменной(определяет самостоятельно)
//var day = Convert.ToInt32(Console.ReadLine());
// convert to int 32 - конвертирует в целые числа (заменяет Parse)
//var negativeDay = day * (-1);
//for (; negativeDay <= day; negativeDay++)
//{
//Console.Write(negativeDay + "\t");
// \t - табуляция (т.е отступ между символами в программе)
//}
