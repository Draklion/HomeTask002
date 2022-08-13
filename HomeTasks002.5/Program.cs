try
{
  Console.WriteLine("Задание 5. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

  Console.Write("Введите любое число: ");
  string numberstr = Console.ReadLine();

  Console.WriteLine(numberstr.Length <= 2 ? $"Третьей цифры нет" : $"Третья цифра числа: {numberstr[2]}");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}