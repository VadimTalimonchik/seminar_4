// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// // Вариант 1.
// int[] array = new int[8]; // создаём массив длиной в 8 чисел
// int i = 0;

// while(i < 7)
// {
//     int k = new Random().Next(0, 2); // генерация случайного чисела от 0 до 1
//     // int k = new Random().Next(2); // генерация случайного чисела от 0 до 1
//     array[i] = k;
//     Console.Write(array[i] + " ");
//     i++;
// }


// Вариант 2.
Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine()!);
 
void Arr (int length)
{
    int[] array = new int[length];
    int i = 0;

    while(i < length)
    {
        int k = new Random().Next(0, 2);
        array[i] = k;
        Console.Write(array[i] + " ");
        i++;
    }
}
Arr(N);


// // Вариант 3. эксперимент
// int[] array = new int [8];
// int i = 0;

// while(i < 8)
// {
//     int k = new Random().Next(0, 2);
//      array[i] = k;

//      if(i == 0)
//     {
//         Console.Write("[ " + array[i] + ", ");
//     }
//     if(i > 0 && i < 8)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     if(i == 8)
//     {
//         Console.Write(array[i] + " ]");
//     }
// i++;
// }  
