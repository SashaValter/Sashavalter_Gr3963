// Задача №0
// Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное само на себя)
Console.WriteLine("Введите число: ");
string? inputNum = Console.ReadLine();
if (inputNum != null)
{
  // парсим введенное число (переводим строку в число)
  int number = int.Parse(inputNum);

  // Находим квадрат числа 
  //int outNum = number * number;
  int outNum = (int)Math.Pow(number, 2);

  // math - класс содержащий все мат. ф-ции. 
  // Pow - метод возведения в степень (число, степень)
  // (int) преобразует тип данных в целые числа, тк 
  // math использует тип данных double

  // Выводим данные в консоль
  Console.WriteLine(outNum);

  // решение задачи в одну строку
  //Console.WriteLine("Квадрат числа: " + Math.Pow(int.Parse(inputNum), 2));
}

// task 2. Проверить, является ли  первое число квадратом второго

string? numline1 = Console.ReadLine();

