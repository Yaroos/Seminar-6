/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   */
int GetNumber(string message)
{
    int resultNumber = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
        Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
        }
    }
    return resultNumber;
}

int b1 = GetNumber("Введите b1 = ");
int k1 = GetNumber("Введите k1 = ");
int b2 = GetNumber("Введите b2 = ");
int k2 = GetNumber("Введите k2 = ");
if(k2 == k1)
{
    Console.WriteLine("Прямые не пересекаются (прямые параллельны)");
}
else
{
    float x = Convert.ToSingle (b1 - b2) / (k2 - k1);
    float y = Convert.ToSingle (k2 * x + b2);
    if (x == 0 & y ==0)
    {
    Console.WriteLine($"Прямые не пересекаются");
    }
    else
    {
    Console.WriteLine($"Точкой пересечения двух прямых будет: {x} и {y}");
    }

}
