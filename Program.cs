// Домашнее задание 1 
        // Задача 1
        Console.WriteLine("Введите два числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a > b ? $"max = {a}" : $"max = {b}");

        // Задача 2
        Console.WriteLine("Введите три числа:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine($"max = {Math.Max(x, Math.Max(y, z))}");

        // Задача 3
        Console.WriteLine("Введите число:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num % 2 == 0 ? "да" : "нет");

        // Задача 4
        Console.WriteLine("Введите число N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 2; i <= N; i += 2)
            Console.Write(i + (i < N - 1 && i + 2 <= N ? ", " : "\n"));

        // Задача 5
        Console.WriteLine("Введите число:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(k % 7 == 0 && k % 23 == 0 ? "да" : "нет");

        // Задача 6
        Console.WriteLine("Введите координаты точки (X и Y):");
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        if (X > 0 && Y > 0) Console.WriteLine("1-я четверть");
        else if (X < 0 && Y > 0) Console.WriteLine("2-я четверть");
        else if (X < 0 && Y < 0) Console.WriteLine("3-я четверть");
        else if (X > 0 && Y < 0) Console.WriteLine("4-я четверть");

        // Задача 7
        Console.WriteLine("Введите число от 10 до 99:");
        int num2 = int.Parse(Console.ReadLine());
        int maxDigit = Math.Max(num2 / 10, num2 % 10);
        Console.WriteLine($"Наибольшая цифра: {maxDigit}");

        // Задача 8
        Console.WriteLine("Введите натуральное число:");
        string number = Console.ReadLine();
        Console.WriteLine(string.Join(", ", number));
    
// Домашнее задание 2
// Задача 1
        Console.WriteLine("Задача 1:");
        int[] array1 = GenerateArray(10, 1, 100);
        int countInRange = array1.Count(n => n >= 20 && n <= 90);
        Console.WriteLine($"Массив: {string.Join(", ", array1)}");
        Console.WriteLine($"Количество элементов в отрезке [20,90]: {countInRange}");

        // Задача 2
        Console.WriteLine("\nЗадача 2:");
        int[] array2 = GenerateArray(10, 1, 100);
        int evenCount = array2.Count(n => n % 2 == 0);
        Console.WriteLine($"Массив: {string.Join(", ", array2)}");
        Console.WriteLine($"Количество чётных чисел: {evenCount}");

        // Задача 3
        Console.WriteLine("\nЗадача 3:");
        double[] array3 = GenerateDoubleArray(10, 0.1, 99.9);
        double max = array3.Max();
        double min = array3.Min();
        Console.WriteLine($"Массив: {string.Join(", ", array3.Select(n => n.ToString("F2")))}");
        Console.WriteLine($"Разница между максимальным ({max:F2}) и минимальным ({min:F2}): {max - min:F2}");
// Домашнее задание 3
int[] numbers = new int[10];
        Random random = new Random();

        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
            if (numbers[i] % 2 == 0)
                evenCount++;
        }

        Console.WriteLine("Массив: " + string.Join(", ", numbers));
        Console.WriteLine($"Количество чётных чисел: {evenCount}");