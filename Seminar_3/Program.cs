/*Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает
 диапазон возможных координат точек в этой четверти (x и y).*/
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
