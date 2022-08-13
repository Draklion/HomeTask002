try
{
  Console.WriteLine("Задание 4. Программа, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.");

  Console.Write("Введите первое число: ");
  int firstNumber = Int32.Parse(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int secondNumber = Int32.Parse(Console.ReadLine());

  Console.WriteLine(firstNumber % secondNumber == 0 ? "Кратно" : $"Не кратно: {firstNumber % secondNumber}");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}