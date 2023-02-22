// Напишите программу, которая выводит случайно число из отрезка [10,99]
// и показывает наибольшую цифру числа
//System.Random - это обращение к ядру компьютера для генерации случайных чисел 
// new - тип данных
System.Random numSintezator = new System.Random();

// Вариант 1
// Next - это метод, который предоставляет следующее число в генерации
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;
if (firstNum > secondNum)
{
  Console.WriteLine("Наибольшая цифра числа: " + firstNum);
}
else
{
  Console.WriteLine("Наибольшая цифра числа: " + secondNum);
}
if (firstNum == secondNum)
{
  Console.WriteLine("Цифры числа равны");
}
// Вариант 2
// ToString - конвертация в строку(тип данных). char - тип данных символы
// ToCharArray - конвертация в массив символов
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0]) - 48;
int secondNumber = ((int)digits[1]) - 48;
// вычитаем 48 потому что используем char. Там код числа выглядит так:
// код числа 5: 5+48 = 53 -> чтоб получить значение самого числа нужно вычесть 48
// числа из типа char кодируются методом ASCII. 
// Грубо говоря мы конвертировали из char в int (можно было ConvertToInt)
// тернарный оператор - если условие выполнилось, то в переменную кладем
// значение1, если не выполнилось - значение2
// <переменная> = (условие)?<значение1>:<значение2>;
int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;
Console.WriteLine("Наибольшая цифра числа: " + resultNumber);

// Вариант 3
// просто вывести все возможные варианты ответов в виде таблицы
// сгенерировать число и вывести ответ

