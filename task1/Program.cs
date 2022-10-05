/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
void printArray()
{
    Console.Clear();
    Console.WriteLine("Приветствую! Эта программа покажет количество положительных чисел из тех, которые ввел пользователь!");
    Console.WriteLine("(Для себя проверил можно ли весь код записать в один Void и c одним массивом решить задачку)");
    int N = 1;
    int[] arr = new int[1000];
    Console.WriteLine("Вводите числа через Enter. Оставьте поле пустым и нажмите Enter - это остановит ввод чисел");
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите число №{N}:");
        string? userNumberString = Console.ReadLine();
        if (userNumberString == "")
        {
            break;
        }
        N++;
        int userNumber = Convert.ToInt32(userNumberString);
        arr[i] = userNumber;
    }
    Console.WriteLine("Спасибо!");
    Console.Write("Вы ввели числа -> ");
    for (int index = 0; index < N - 2; index++)
    {
        Console.Write($"{arr[index]}, ");
    }
    Console.WriteLine($"{arr[N - 2]}.");
    int count = 0;
    Console.Write("Положительные числа -> ");
    for (int index = 0; index < N; index++)
    {
        if (arr[index] > 0)
        {
            Console.Write($"{arr[index]}({index + 1}) ");
            count++;
        }
    }
    Console.WriteLine("");
    Console.WriteLine($"Количество положительных чисел -> {count}");
    Console.WriteLine("Bye!");
}
printArray();