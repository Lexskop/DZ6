/*
*Задача(сложная не на оценку) *
Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу.
*/
void calc(int[] userArray, int target)
{
    int[] stack = new int[userArray.Length];
    int count = 0;
    void variants(int i, int target)
    {
        if (target < 0)
        {
            return;
        }
        if (target == 0)
        {
            for (int j = 0; j < count; j++)
            {
                Console.Write($"{stack[j]} ");
            }
            Console.WriteLine();
            return;
        }
        if (i < userArray.Length)
        {
            stack[count++] = userArray[i];
            variants(i + 1, target - userArray[i]);
            --count;
            variants(i + 1, target);
        }
    }
    variants(0, target);
}
Console.WriteLine("Приветствую! Эта программа покажет все возможные решения чтобы из суммы цифр от 1 до 9 получить Ваше число.");
Console.WriteLine("Цифры в комбинациях не повторяются");
Console.WriteLine("Введите число, которое нужно получить:");
int userNumber = Convert.ToInt32(Console.ReadLine());

calc(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, userNumber);