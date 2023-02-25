// Задача 17. Напишите программу, которая на вход принмает точки x,y и выдает номер
// четвери плоскости, в которой находится эта точка
//  решение без написания метода
// Console.Write("Введите x: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int numY = Convert.ToInt32(Console.ReadLine());
// if (numX > 0 && numY > 0)
// {
//   Console.WriteLine("Точка находится в 1 четверти координатной плоскости");
// }
// if (numX>0&&numY<0)
// {
// Console.WriteLine("Точка находится во 2 четверти координатной плоскости");
// }
// if (numX<0&&numY>0)
// {
// Console.WriteLine("Точка находится в 4 четверти координатной плоскости");
// }
// if (numX<0&&numY<0)
// {
//   Console.WriteLine("Точка находится в 3 четверти координатной плоскости");
// }
// вариант решения методом
// спроектируем метод
// <тип> <имя метода> (<тип переменной> <название переменной>)
// {
  //return <тип>
//}
//Метод читает данные от пользователя
// в данном случае мы бросаем в метод некое сообщение, а получаем некое значение
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine()??"0");
}
// Метод определяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
  if(x>0&&y>0) Console.WriteLine("Точка в первой четверти");
  if(x>0&&y<0) Console.WriteLine("Точка во второй четверти");
  if(x<0&&y>0) Console.WriteLine("Точка в четвертой четверти");
  if(x<0&&y<0) Console.WriteLine("Точка в третьей четверти");
}
int coordX = ReadData("Введите координату x: ");
int coordY = ReadData("Введите координату y: ");
PrintQuterTest(coordX,coordY);