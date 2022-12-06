// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Input 5 numbers");
string number = Convert.ToString(Console.ReadLine());
// Проверка на ввод букв
double numericCheck;
bool isNumber=double.TryParse(number, out numericCheck);

if (numericCheck==0)
    Console.WriteLine("You should input only numbers");
else
// Проверка на ввод более или менее 5 цифр    
    if (number.Length > 5 || number.Length < 5)
        Console.WriteLine("You should input only 5 numbers");
    else
    // Выявление палиндрома
        if (number[0] == number[4] && number[1] == number[3])
            Console.WriteLine("Number " + number + " is palindrom");
        else
            Console.WriteLine("Number " + number + " is not palindrom");

