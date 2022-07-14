// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

void PrintNaural(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    if (numberN % 2 == 1)
    {
        numberN--;
    }
    PrintNaural(numberM, numberN - 2);
    System.Console.Write($"{numberN}; ");
}

int numberM = Promt("Введите число M: ");
int numberN = Promt("Введите число N: ");
PrintNaural(numberM, numberN);
System.Console.WriteLine();


