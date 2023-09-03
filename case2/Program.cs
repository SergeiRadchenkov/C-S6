/* Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Checking(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");
int num3 = InputNum("Введите третье число: ");
bool result = Checking(num1, num2, num3);
Console.WriteLine(result == true?"Да":"Нет");