// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
string number = Convert.ToString(Console.ReadLine());

// Проверка на ввод букв и отрицательных чисел
bool isNumber = double.TryParse(number, out double numericCheck);

if (numericCheck <= 0)
    Console.WriteLine("You should input only numbers 1 to N");
else
{
    int number2 = Convert.ToInt32(number);
    Console.WriteLine(); // пустая строка для отделения вывода таблицы
    for (double i = 1; i <= number2; i++)
        Console.WriteLine(Math.Pow(i, 3));
}