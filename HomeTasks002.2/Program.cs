try
{
  Console.WriteLine("Задание 2. Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
  int calculator1(int number)
  {
    string numberstr = number.ToString();
    number = Int32.Parse(numberstr[1].ToString());

    return number;
  }

  int calculator2(int number)
  {
    number = number / 10;
    number = number % 10;
    return number;
  }

  Console.Write("Введите трехзначное число: ");
  int number = Int32.Parse(Console.ReadLine());
  Console.WriteLine($"Случайное число: {number}");
  Console.WriteLine($"Решение через строку: {calculator1(number)}");
  Console.WriteLine($"Решение через вычисление: {calculator2(number)}");

}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}