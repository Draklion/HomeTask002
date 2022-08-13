try
{
  Console.WriteLine("Задание 8. Программа, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");

  Console.Write("Введите первое число: ");
  int firstNumber = Int32.Parse(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int secondNumber = Int32.Parse(Console.ReadLine());

  Console.WriteLine(firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber ? "Да" : "Нет");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}