// Задания первого семинара

Console.Clear();
restart:
Console.Write("Что бы запустить какую то конкретную задау введите номер этой задачи: ");
int Task = int.Parse(Console.ReadLine());

switch(Task){
    case 0: 
        Console.Write("Hello, World!");
    break;
    case 1:
    /*Задача 1: Напишите программу, которая на вход принимает 2 числа и проверяет, 
                является ли первое число квадратом второго.*/

    Console.WriteLine("Задача 1: Программа на вход принимает 2 числа и проверяет, является ли первое число квадратом второго.");
    Console.WriteLine("a = 25, b = 5 -> да");
    Console.WriteLine("a = 2, b = 10 -> нет");
    Console.WriteLine("a = 9, b = -3 -> да");
    Console.WriteLine("a = -3, b = 9 -> нет");

        //Console.Clear();
        Console.Write("Введите первое число: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b1 = int.Parse(Console.ReadLine());

        if (b1 * b1 == a1)
            Console.Write($"a = {a1}, b = {b1} -> да");
        else
            Console.Write($"a = {a1}, b = {b1} -> нет");
    break;
    case 2:
    /*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
                какое число большее, а какое меньшее.*/

    Console.WriteLine("Задача 2: Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("a = 5; b = 7 -> max = 7");
    Console.WriteLine("a = 2 b = 10 -> max = 10");
    Console.WriteLine("a = -9 b = -3 -> max = -3");

        //Console.Clear();
        Console.Write("Введите первое число: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b2 = int.Parse(Console.ReadLine());

        if (a2>b2)
            Console.Write($"Из чисел {a2} и {b2} наибольшее число равно {a2}");
        else if (b2>a2)
            Console.Write($"Из чисел {a2} и {b2} наибольшее число равно {b2}");
        else 
            Console.Write($"Числа {a2} и {b2} равны.");
    break;
    case 3:
    /*Задача 3: Напишите программу, которая будет выдавать название дня
                недели по заданному номеру.*/

    Console.WriteLine("Задача 3: Программа выдает название дня недели по заданному номеру.");
    Console.WriteLine("3 -> Среда");
    Console.WriteLine("5 -> Пятница");

        //Console.Clear();
        Console.Write("Введите день недели: ");
        int num_day = int.Parse(Console.ReadLine());

        switch(num_day){
            case 1:
            Console.Write("1 -> Понедельник");
            break;
            case 2:
            Console.Write("2 -> Вторник");
            break;
            case 3:
            Console.Write("3 -> Среда");
            break;
            case 4:
            Console.Write("4 -> Четверг");
            break;
            case 5:
            Console.Write("5 -> Пятница");
            break;
            case 6:
            Console.Write("6 -> Суббота");
            break;
            case 7:
            Console.Write("7 -> Воскресенье");
            break;
            default: 
            Console.Write("Введите коректное значение");
            break;
        }
    break;
    case 4:
    /* Задача 4: Напишите программу, которая принимает на вход три числа
                 и выдаёт максимальное из этих чисел.*/

    Console.WriteLine("Задача 4: Программа принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("2, 3, 7 -> 7");
    Console.WriteLine("44 5 78 -> 78");
    Console.WriteLine("22 3 9 -> 22");

        //Console.Clear();
        Console.Write("Введите первое число: ");
        int a4 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b4 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c4 = int.Parse(Console.ReadLine());

        int max4 = a4;

        if (b4 > max4)
            max4 = b4;
        if (c4 > max4)
            max4 = c4;

        Console.Write($" {a4} {b4} {c4} -> {max4}");
    break;
    case 5:
    /* Задача 5: Напишите программу, которая на вход принимает одно число N, 
                 а на выходе показывает все целые числа в промежутке от -N до N.*/

    Console.WriteLine("Задача 5: Программа на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N.");
    Console.WriteLine("4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4");
    Console.WriteLine("2 -> -2, -1, 0, 1, 2");

        Console.Write("Введите любое число: ");
        int N5 = int.Parse(Console.ReadLine());
        Console.Write($"{N5} -> ");
        int NN = N5 * (-1);
        if (NN < N5)
            for (int i = NN; i < N5 + 1; i++){
                Console.Write($"{i} ");
            }
    break;
    case 6:
    /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
                 является ли число чётным (делится ли оно на два без остатка).*/

    Console.WriteLine("Задача 6: Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("4 -> да");
    Console.WriteLine("-3 -> нет");
    Console.WriteLine("7 -> нет");

        //Console.Clear();
        Console.Write("Введите любое число: ");
        int a6 = int.Parse(Console.ReadLine());

        if (a6 % 2 == 0)
            Console.Write($"Число {a6} четное");
        else
            Console.Write($"Число {a6} нечетное");
    break;
    case 7:
    /*Задача 7: Напишите программу, которая на вход принимает трёхзначное
                число и на выходе показывает последнюю цифру этого числа.*/

    Console.WriteLine("Задача 7: Программа принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
    Console.WriteLine("456 -> 6");
    Console.WriteLine("782 -> 2");
    Console.WriteLine("918 -> 8");
        again:
        Console.Write("Введите любое трехзначное число: ");
        int N7 = int.Parse(Console.ReadLine());
        String SN = Convert.ToString(N7);

        if (N7 >= 100 && N7 < 1000)
            Console.WriteLine($"{N7} -> {SN[2]}");
        else
        goto again;         
        
    break;
    case 8:
    /* Задача 8: Напишите программу, которая на вход принимает число (N), 
                 а на выходе показывает все чётные числа от 1 до N.*/
    Console.WriteLine("Задача 8: Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("5 -> 2, 4");
    Console.WriteLine("8 -> 2, 4, 6, 8");

        //Console.Clear();
        Console.Write("Введите любое число: ");
        int N8 = int.Parse(Console.ReadLine());
        int num8 = 0;
        Console.Write($"{N8} -> ");
        if (N8 % 2 == 0){
        while (num8 != N8){
            num8 = num8 + 2;
            Console.Write($"{num8} ");
        }}
        else
        while(num8 != N8-1){
            num8 = num8 +2;
            Console.Write($"{num8} ");
        }

    break;
    default: 
        Console.WriteLine("Введите корректное значение от 1 до 8");
    goto restart;
}






