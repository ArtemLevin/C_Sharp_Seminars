// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите длину массива ");
int N = int.Parse(Console.ReadLine());

void massive(int dlina)

{
    int[] array = new int[dlina];
    int i = 0;

    while (i < dlina)
    {
        int k = new Random().Next(0, 2);
        array[i] = k;
    if (i == 0)
    {
        Console.Write("[ " + array[i] + ", ");
    }
    if (i == dlina - 1)
    {
        Console.Write(array[i] + " ]");
    }
    if (i >0 && i < dlina - 1) 
    {
        Console.Write(array[i] + ", ");
    }
        i++;
    }

}

massive(N);

