try
{
  Console.WriteLine("Задание 3. Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

  Console.Write("Введите трехзначное число: ");
  string numberstr = Console.ReadLine();

  Console.WriteLine($"Число без второй цифры: {numberstr[0]}{numberstr[numberstr.Length - 1]}");
}
catch
{
  Console.WriteLine("Вы ввели некорректное значение.");
}