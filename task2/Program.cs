// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


void main()
{
    int numberA = Readint("Введите первое число : ");
    int numberB = Readint("Введите второе  число: ");
    System.Console.WriteLine(A(numberA, numberB));
}

int A(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0 && n != 0) return A(n - 1, 1);
    else return A(n - 1, A(n, m- 1));

}



int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

main();
