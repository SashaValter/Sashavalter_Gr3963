// Задача 16. НАпишите программу, которая принимает на вход 2 числа
// и проверяет является ли первое число квадратом второго и наоборот
// Console.WriteLine("Введите первое число ");
// int num1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите второе число ");
// int num2 = int.Parse(Console.ReadLine() ?? "0");
// //bool oper - проверяет выполняется ли условие( типа true or false)
// // в данном методе условие задаем через переменную oper(operation)
// bool oper = (num1 * num1 == num2);
// if (oper)
// {
//   Console.WriteLine("Число 1 квадрат числа 2");
// }
// else
// {
//   Console.WriteLine("Число 1 не квадрат числа 2");
// }

// Var 2 с методом void
// здесь условие задается через функцию, затем подставляются значения
// и проверяется выполнение условия
void squareTest(int firstNum, int secondNum)
{
  if (firstNum == Math.Pow(secondNum, 2))
  {
    Console.WriteLine("Число 1  является квадратом 2");
  }
  else
  {
    Console.WriteLine("Число 1  не является квадратом 2");
  }
}

Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine() ?? "0"); // проверка на null safety
// var num1 = Convert.ToInt32(Console.ReadLine());
// var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
squareTest(num1, num2);
squareTest(num2,num1);


