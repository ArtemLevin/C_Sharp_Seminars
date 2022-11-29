
Console.Write("Введите номер дня недели " );

int a = int.Parse(Console.ReadLine());



if (a == 3)
{
    Console.WriteLine("День недели Среда");

}
if (a == 5)
{
Console.WriteLine("День недели Пятница"); 
}

if (a == 1)
{
    Console.WriteLine("День недели Понедельник");

}
if (a == 2)
{
Console.WriteLine("День недели Вторник"); 
}
if (a == 4)
{
Console.WriteLine("День недели Четверг"); 
}
if (a == 6)
{
Console.WriteLine("День недели Суббота"); 
}

if (a == 7)
{
 Console.WriteLine("День недели Воскресенье"); 
}

if (a > 7) 
{
    Console.WriteLine("Введены некорретные данные"); 
}

