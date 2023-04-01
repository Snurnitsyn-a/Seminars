/*Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает
 диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Enter the number of the quarter");
int Q = int.Parse(Console.ReadLine());
string result = GetXY(Q);
Console.WriteLine(result);
string GetXY(int Q)
{
    if (Q == 1)
    {
        return "x > 0 && y > 0";
    }
    if (Q == 2)
    {
        return "x < 0 && y > 0";
    }
    if (Q == 3)
    {
        return "x < 0 && y < 0";
    }
    if (Q == 4)
    {
        return "x > 0 && y < 0";
    }
    return "Invalid data has been inserted";
}
*/

/*
Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
*/
/*
Console.WriteLine("Enter the x coordinates");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the y coordinates");
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
double result = GetDistance(x1, x2, y1, y2);
Console.WriteLine(result);

double GetDistance(int x1, int x2, int y1, int y2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return (double)dist;
}
*/
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/
int n = int.Parse(Console.ReadLine());
