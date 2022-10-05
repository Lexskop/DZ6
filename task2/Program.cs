/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double[] arr = new double[4];
void printArray(double[] userArray, double calcX, double calcY)
{
    calcX = (userArray[2] - userArray[0]) / (userArray[1] - userArray[3]);
    calcY = userArray[1] * calcX + userArray[0];
    Console.WriteLine($"Значения пользователя: b1 = {userArray[0]}, k1 = {userArray[1]}, b2 = {userArray[2]}, k2 = {userArray[3]}");
    Console.WriteLine($"Точка пересечения двух прямых (X;Y) -> ({calcX:N1};{calcY:N1})");
}

int userData(int userNumber)
{
    Console.WriteLine("Вводите числа через Enter");
    for (int i = 0; i < 4; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("Введите число b1:");
            userNumber = Convert.ToInt32(Console.ReadLine());
            arr[i] = userNumber;
        }
        if (i == 1)
        {
            Console.WriteLine("Введите число k1:");
            userNumber = Convert.ToInt32(Console.ReadLine());
            arr[i] = userNumber;
        }
        if (i == 2)
        {
            Console.WriteLine("Введите число b2:");
            userNumber = Convert.ToInt32(Console.ReadLine());
            arr[i] = userNumber;
        }
        if (i == 3)
        {
            Console.WriteLine("Введите число k2:");
            userNumber = Convert.ToInt32(Console.ReadLine());
            arr[i] = userNumber;
        }
    }
    return userNumber;
}

Console.WriteLine("Приветствую! Эта программа покажет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Значения b1, k1, b2 и k2 задаются пользователем");
userData(0);
printArray(arr, 0, 0);