// Задача 3. Написать программу которая будет выдавать название дня недели
// по номеру
Console.WriteLine("Введите число: ");
string? lineDay = Console.ReadLine();
if (lineDay != null)
{
  int day = int.Parse(lineDay); string[] dayWeek = new string[7];
  dayWeek[0] = "понедельник";
  dayWeek[1] = "вторник";
  dayWeek[2] = "среда";
  dayWeek[3] = "четверг";
  dayWeek[4] = "пятница";
  dayWeek[5] = "суббота";
  dayWeek[6] = "воскресенье";
  Console.WriteLine(dayWeek[day - 1]);
}

//string outDayofWeek = System.Globalization.CultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typesof(DayOfWeek)).GetValues(day));
