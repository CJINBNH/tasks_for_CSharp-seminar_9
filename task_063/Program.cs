// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
// N = 5 -> "1, 2, 3, 4, 5"

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
     Console.Write($"{number} ");
     PrintNumbers(number - 1);
}
PrintNumbers(n);
