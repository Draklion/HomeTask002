try
{
  Console.WriteLine("Задание 7. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

  Console.Write("Введите число дня недели: ");
  int number = Int32.Parse(Console.ReadLine());

  Console.WriteLine(number <= 7 && number >= 1 ? ((number == 1 || number == 2 || number == 3 || number == 4 || number == 5) ? "Нет" : "Да") : "Дней недели всего 7!");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}