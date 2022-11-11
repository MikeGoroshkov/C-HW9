/* Задача 68: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Main();

void Main()
{
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write(AckermannFunktion(m, n));
}

int AckermannFunktion(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermannFunktion(m - 1, 1);
    return AckermannFunktion(m - 1, AckermannFunktion(m, n - 1));
}