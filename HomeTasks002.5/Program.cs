try
{
  Console.WriteLine("Задание 5. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

  string calculator1(string numberstr)
  {
    numberstr = numberstr.Length <= 2 ? "Третьей цифры нет" : $"{numberstr[2]}";

    return numberstr;
  }

  string calculator2(string numberstr)
  {
    int number = Int32.Parse(numberstr);

    if (number < 100)
    {
      return number.ToString("Третьей цифры нет");
    }
    else
    {
      for (int i = 0; i <= numberstr.Length - 4; i++)
      {
        number = number / 10;
      }

      number = number % 10;

      return number.ToString();
    }
  }

  Console.Write("Введите любое число: ");
  string numberstr = Console.ReadLine();

  Console.WriteLine($"Решение через строку: {calculator1(numberstr)}");
  Console.WriteLine($"Решение через вычисление: {calculator2(numberstr)}");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}