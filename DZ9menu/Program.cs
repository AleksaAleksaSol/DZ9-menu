void TaskMenu()
{
    bool exitOut = true;
    Console.Clear();
    while (exitOut == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("_________________________________________________________________________________________________________________________");
        Console.WriteLine("Задача 64:Задайте значение N. Напишите программу,которая выведет все натуральные числа в промежутке ");
        Console.WriteLine("от N до 1. Выполнить с помощью рекурсии.N = 5 -> 5, 4, 3, 2, 1");
        Console.WriteLine();
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("M = 1; N = 15 -> 120  или  M = 4; N = 8. -> 30");
        Console.WriteLine();
        Console.WriteLine("Задача 68:Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("m = 2, n = 3 -> A(m,n) = 9   или  m = 3, n = 2 -> A(m,n) = 29");
        Console.WriteLine("_________________________________________________________________________________________________________________________");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Введите номер задачи(64, 66, 68 либо q/Q для выхода):");
        string selectTask = "";
        selectTask = Console.ReadLine();

        switch (selectTask)
        {
            case "64":
                {
                    Console.Clear();
                    Task_64();
                    break;
                }

            case "66":
                {
                    Console.Clear();
                    Task_66();
                    break;
                }

            case "68":
                {
                    Console.Clear();
                    Task_68();
                    break;
                }

            case "q":
                {
                    exitOut = false;
                    Console.Clear();
                    break;
                }

            case "Q":
                {
                    exitOut = false;
                    Console.Clear();
                    break;
                }

            default:
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода! Попробуйте ещё раз!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
        }
    }
}

// ##Методы для решения задач:
//Введение числа
int SetNumber(string numberName)
{
    Console.Write($"Введите значение {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Рекурсия снижения значения
int RangeNumber(int numberN, int start = 1)
{
    if (numberN == 0)
        return 1;
    else if (numberN == 0)
    {
        Console.Write($"{numberN}");
    }
    else Console.Write($"{numberN}, ");
    return numberN - RangeNumber(numberN - 1);
}

// Рекурсия суммирования значения
int SumMtoN(int M, int N)
{
    int Sum = 0;
    if (M == N)
        return N;
    return N += SumMtoN(M, N - 1);
}

//Функция Аккермана
int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return AkkermanFunction(m - 1, 1);
    else
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
}

// ##Вызов методов к задачам:
// Вызов методов к задаче 64
void Task_64()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Решение задачи №64, про выдачу натуральных значений от N до 1:");
    Console.ForegroundColor = ConsoleColor.White;
    int number = SetNumber("N");
    Console.Write($"N = {number} -> ");
    RangeNumber(number);
}

// Вызов методов к задаче 66
void Task_66()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Решение задачи №66, про поиск суммы чисел от M до N");
    int M = SetNumber("M");
    int N = SetNumber("N");
    Console.Write($"M = {M}; N = {N} -> {SumMtoN(M, N)}");
}

// Вызов методов к задаче 68
void Task_68()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Решение задачи №68, про функцию Аккермана:");
    Console.ForegroundColor = ConsoleColor.White;
    int m = SetNumber("m");
    int n = SetNumber("n");
    Console.Write($"m = {m}; n = {n} -> A(m,n) = {AkkermanFunction(m, n)}");
}

TaskMenu();