// Задача 14. Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно 7 или 23
//Var1 (через генерацию случайного числа)
System.Random numSintezator = new System.Random();
int rndNumber = numSintezator.Next(1,100);
Console.WriteLine("Случайное число - " + rndNumber);
if (rndNumber % 23 == 0 && rndNumber % 7 == 0)
{
  Console.WriteLine("Число кратно 7 и 23");
}
else
{
  Console.WriteLine("Число не кратно 7 и 23");
}

// Var2
// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// if (num % 23 == 0 && num % 7 == 0)
// {
//   Console.WriteLine ("Число кратно и 7 и 23!");
// }
// else
// {
//   Console.WriteLine ("Число не кратно 7 и 23!");
// }

//Var3
// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// //bool oper - проверяет выполняется ли условие( типа true or false)
// // в данном методе условие задаем через переменную oper(operation)
// bool oper = (num % 23 == 0) && (num % 7 == 0);
// if (oper)
// {
//   Console.WriteLine("Число кратно и 7 и 23!");
// }
// else
// {
//   Console.WriteLine("Число не кратно 7 и 23!");
// }