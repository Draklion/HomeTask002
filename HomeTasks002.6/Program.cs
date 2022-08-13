try
{
  Console.WriteLine("Задание 6. Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");

  Console.Write("Введите число: ");
  int number = Int32.Parse(Console.ReadLine());

  Console.WriteLine(number % 7 == 0 && number % 23 == 0 ? "Да" : "Нет");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}