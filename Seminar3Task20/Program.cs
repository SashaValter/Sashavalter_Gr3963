// Задача 20. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между этими двумя точками в 2d пространстве
// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// метод culcLength
double culcLength(int x1, int x2, int y1, int y2)
{
  //return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));// math.sqrt - находит квадратный корень
  return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)); // math.pow - возводит в квадрат
}
// метод print data
// это позволит нам вставлять какое-то сообщение например:
// длина между точками - <значение в методе culcLength>
void PrintData(string msg, double val)
{
  Console.WriteLine(msg + val);
}
// вводим координаты двух точек методом ReadData
int coordX1 = ReadData("Введите координату x1: ");
int coordX2 = ReadData("Введите координату x2: ");
int coordY1 = ReadData("Введите координату y1: ");
int coordY2 = ReadData("Введите координату y2: ");
// обращаемся к методу подсчета culcLength
// вводим переменную res 
double res = culcLength(coordX1, coordX2, coordY1, coordY2);
//выводим результат при помощи метода PrintData
PrintData("Расстояние между точками - ", res);