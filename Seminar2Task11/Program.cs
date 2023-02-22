// Напишите программу, которая выводит случайно 3х значное число и удаляет
// 2ю цифру этого числа
// положили в переменную num рандомное число от 100 до 1000
int num = new Random().Next(100, 1000);
Console.WriteLine("Случайное число - " + num);
int lastDigit = num % 10;
int firstDigit = num / 100;
num = firstDigit * 10 + lastDigit;
Console.WriteLine("Новое число - " + num);