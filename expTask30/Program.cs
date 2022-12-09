// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите длину массива ");
int N = int.Parse(Console.ReadLine());

int[] massive(int dlina)

{
    int[] array = new int[dlina];
    int i = 0;

    while (i < dlina)
    {
        int k = new Random().Next(0, 2);
        array[i] = k;
        i++;
    }
    return array;

}

massive(N);

void PrintArray(int [] initarray)
{
    int dlina = initarray.Length;
    int i = 0;

    while (i < dlina)
    {

    if (i == 0)
        {
            Console.Write("[ " + initarray[i] + ", ");
        }
        if (i == dlina - 1)
        {
            Console.Write(initarray[i] + " ]");
        }
        if (i >0 && i < dlina - 1) 
        {
            Console.Write(initarray[i] + ", ");
        }
        i++;
    }
}

PrintArray(massive(N));

