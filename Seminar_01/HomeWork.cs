class HomeWork
{
    static void Main(string[] arg)
    {
        #region задача 2
        int value1;
        int value2;
        Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
        Console.Write("Введите число 1: ");
        int.TryParse(Console.ReadLine(), out value1);
        Console.Write("Введите число 2: ");
        int.TryParse(Console.ReadLine(), out value2);
        if (value1 > value2)
        {
            Console.WriteLine($"число 1: {value1} больше числа 2: {value2}");
        }
        else if (value1 < value2)
        {
            Console.WriteLine($"число 1: {value1} меньше числа 2: {value2}");
        }
        else
        {
            Console.WriteLine($"Числа {value1} и {value2} равны!!");
        }
        #endregion

        Console.WriteLine();

        #region задача 4
        int[] numbers = new int[3];
        Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int.TryParse(Console.ReadLine(), out numbers[i]);
        }
        int maxnumber = numbers[0];
        foreach (var item in numbers)
        {
            if (maxnumber < item)
                maxnumber = item;
        }
        Console.WriteLine($"Максимальное число {maxnumber}");
        #endregion

        Console.WriteLine();

        #region задача 6
        int evenNumber;
        Console.Write("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).\nВведите число: ");
        int.TryParse(Console.ReadLine(), out evenNumber);
        if (evenNumber % 2 == 0) Console.WriteLine("Число четное");
        else Console.WriteLine("Число не четное");
        #endregion

        Console.WriteLine();

        #region задача 8
        int evenN;
        Console.Write("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.\nВведите число N: ");
        int.TryParse(Console.ReadLine(), out evenN);
        int counter = 1;
        while (counter <= evenN)
        {
            if (counter % 2 == 0)
            {
                Console.WriteLine(counter);
            }
            counter++;
        }
        #endregion
    }
}
