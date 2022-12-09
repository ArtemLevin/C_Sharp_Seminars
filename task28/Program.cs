// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число "); // просим пользователя ввести число
int N = int.Parse(Console.ReadLine()); // компьютер принимает от пользователя число

void proizv(int num) // объявление метода

{
    int i = 1;
    int proizvedenie = 1;
    while (i <= N)
    {
        proizvedenie *= i;
        // Console.WriteLine($"Произведение равно: {proizvedenie} ");
        // Console.WriteLine($"i до увеличения равно: {i} ");
        i++;
        // Console.WriteLine($"i после увеличения равно: {i} ");
    }

    Console.WriteLine($"Произведение равно: {proizvedenie} ");
}

proizv(N);