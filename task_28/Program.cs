// Задача 28: 
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

void Production(int num)
{
    int i = 1; // начинаем считать от 1, т.к. если будет 0, то произведение будет 0
    while(i < N)
    {
        num *= i;
        i++;
    }
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {num}.");
}
Production(N);


// ----------
// альтернативный способ с пошаговым выводом прохождения цикла

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// void A(int num)
// {
//     int i = 1;
//     int P = i;
//     while(i <= N)
//     {
//         P *= i;
//         Console.WriteLine($"Произведение: {P}.");
//         Console.WriteLine($"До: {i}.");
//         i++;
//         Console.WriteLine($"После: {i}.");
        
//     }
//     Console.WriteLine($"Произведение: {P}.");
// }
// A(N);