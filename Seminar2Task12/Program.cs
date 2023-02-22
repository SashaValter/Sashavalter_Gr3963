// Напишите программу, которая на вход принимает 2 числа и выводить
// является ли второе число кратным первому, если не является,
// то программа выводит остаток от деления
Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine() ?? "0"); // проверка на null safety
// var num1 = Convert.ToInt32(Console.ReadLine());
// var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int rem = num1 % num2;
if (rem == 0)
{
  Console.Write("число 2 кратно числу 1");
}
else
{
  Console.Write("число 2 не кратно числу 1, а остаток - " + rem);
}