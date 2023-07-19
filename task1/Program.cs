// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void main()
{
    int numberA = Readint("Введите первое число : ");
    int numberB = Readint("Введите второе  число: ");
    int sum = 0;
    System.Console.WriteLine($"сумма чисел от {numberA} до {numberB} = {SumNumbers(numberA, numberB, sum)}");
}

int SumNumbers(int numberA, int numberB, int sum)
{
    if (numberA > numberB) return 0;

    return sum += numberA + SumNumbers(numberA + 1, numberB, sum);
}

int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

main();