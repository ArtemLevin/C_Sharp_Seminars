// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0

int[] array = new int[8];
int i = 0;

while (i <=7)
{
    int k = new Random().Next(0,2);
    array[i] = k;
    if (i == 0)
    {
        Console.Write("[ " + array[i] + ", ");
    }
    if (i == 7)
    {
        Console.Write(array[i] + " ]");
    }
    if (i >0 && i < 7) 
    {
        Console.Write(array[i] + ", ");
    }
    i++;
}


