// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int PrintSumNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }
    return PrintSumNumbers(numberM, numberN - 1) + numberN;
}

int numberM = Promt("Введите число M: ");
int numberN = Promt("Введите число N: ");
int answer = PrintSumNumbers(numberM, numberN);
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {answer}");



