/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string DecToBin(int decNum)
{
    string bin = "";
    while (decNum != 0)
    {
        int reminder = decNum % 2;
        bin = $"{reminder}" + bin;
        decNum = decNum / 2;
    }
    return bin;
}

int number = InputNum("Введите число: ");
string answer = DecToBin(number);
Console.WriteLine(answer);