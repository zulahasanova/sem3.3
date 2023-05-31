семинар 3.3

// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.Write($"Введите точку X:");
int x = int.Parse(Console.ReadLine()!);
Console.Write($"Введите точку Y:");
int y = int.Parse(Console.ReadLine()!);

//1 четверть - x > 0, y > 0
//2 четверть - x < 0, y > 0
//3 четверть - x < 0, y < 0
//4 четверть - x > 0, y < 0

if(x > 0 && y > 0)
{
   Console.Write($"1");
}
if(x < 0 && y > 0)
{
   Console.Write($"2");
}
if(x < 0 && y < 0)
{
   Console.Write($"3");
}
if(x > 0 && y < 0)
{
   Console.Write($"4");
}

/* Задача 18:
 Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y). */

 Console.Write($"Введите номер четверти:");
int quarter = int.Parse(Console.ReadLine()!);

switch(quarter)
{
    case 1:{
    Console.Write($"x, y");
    break;
    }
    case 2:{
    Console.Write($"-x, y");
    break;
    }
    case 3:{
    Console.Write($"-x, -y");
    break;
    }
    case 4:{
    Console.Write($"x, -y");
    break;
    }
    default:{
        Console.Write($"Введена неправильная четверть");
        break;
    }
}
//с if
if(a == 1)
Console.Write($"x, y");
else if(a == 2)
Console.Write($"-x, y");
else if(a == 3)
Console.Write($"-x, -y");
else if(a == 4)
Console.Write($"x, -y");

/* 20 Напишите программу,
 которая принимает на вход координаты двух точек и находит
 расстояние между ними в 2D пространстве.

 A (3,6); B(2, 1)-> 5,09
 A(7, -5); B(1, -1)-> 7,21
sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
double s = Math.Sqrt(...); */

 Console.Write($"Введите A:");
int x1 = int.Parse(Console.ReadLine()!);
 Console.Write($"Введите A1:");
int y1 = int.Parse(Console.ReadLine()!);
 Console.Write($"Введите B:");
int x2 = int.Parse(Console.ReadLine()!);
 Console.Write($"Введите B1:");
int y2 = int.Parse(Console.ReadLine()!);
//формула: AB = √(xb - xa)2 + (yb - ya)2

Console.Write(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
//решение учителя
double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow(y1 - y2, 2)); //(x1 - x2) * (x1 - x2)\
Console.Write($"{d:f2}"); //f2 - после запятой показывает 2 числа, f3 -3 числа

/* Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.

 5 -> 1, 4, 9, 16, 25.

 2 -> 1,4 */

  Console.Write($"Введите число:");
int a = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= a; i++)
{
   int b = i * i;
   Console.Write($"{b} ");
} 
//решение учителя
// c массивом
int[] array = new int[a];
for (int i = 1; i <= a; i++)
{
    array[i - 1] = i * i; //минусовать 1, чтобы массив был с 0. 
}
for (int i = 0; i < a; i++)
{
    Console.Write($"{array[i]} ");
}

//обычное решение
for (int i = 0; i <= a; i++)
{
    Console.WriteLine($"{i} в квадрате = {i * i}");
}