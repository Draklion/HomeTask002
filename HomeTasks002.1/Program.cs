try
{
  Console.WriteLine("Задание 1. Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.");
  int calculator1(int number)
  {
    string numberstr = number.ToString();
    number = Int32.Parse(numberstr[numberstr.Length - 1].ToString()) > Int32.Parse(numberstr[0].ToString()) ?
    Int32.Parse(numberstr[numberstr.Length - 1].ToString()) : Int32.Parse(numberstr[0].ToString());

    return number;
  }

  int calculator2(int number)
  {
    number = number / 10 > number % 10 ? number / 10 : number % 10;
    return number;
  }

  var number = new Random().Next(10, 100);
  Console.WriteLine($"Случайное число: {number}");
  Console.WriteLine($"Решение через строку: {calculator1(number)}");
  Console.WriteLine($"Решение через вычисление: {calculator2(number)}");

}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}