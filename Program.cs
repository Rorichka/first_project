using System;


namespace ProjectForGitHub__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = " ";
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Вас приветсвует C-3PO, введите ваше имя: ");
                string x = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
            
            do 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Здравствуйте, {x}, рад вас видеть");
                Console.WriteLine();

                    Console.WriteLine("Выберите пункт для работы с алгоритмами в языке программировании С#:\n1 - математические модели\n2 - работа с условными конструкторами\n3 - " +
                "массивы\n0 - завершить программу" );
                    Console.WriteLine();
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                if (y == 0)
                {
                    break;
                }

                while (true)
                    {
                    if (y == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{x}, вы находитесь в разделе 'Математические модели'");
                        Console.WriteLine();

                        Console.WriteLine("Выберите задачу, с которой вы бы хотели поработать:\n1 - логические операции\n2 - арифметические операции\n3 - " +
                            "операции сравнения\n4 - циклы\n0 - возврат в прерыдущее меню");
                        Console.WriteLine();
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.ResetColor();

                        if (t == 0)
                        {
                            break;
                        }
                        if (t == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{x}, вы перешли в раздел 'Логические операции'");
                            Console.WriteLine();
                            logical_operations();
                            Console.ResetColor();
                        }
                        else if (t == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{x}, вы перешли в раздел 'Арифметические операции'");
                            Console.WriteLine();
                            arithmetic_operations();
                            Console.ResetColor();
                        }
                        else if (t == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{x}, вы перешли в раздел 'Операции сравнения'");
                            Console.WriteLine();
                            comparison_operations();
                            Console.ResetColor();
                        }
                        else if (t == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{x}, вы перешли в раздел 'Циклы'");
                            Console.WriteLine();
                            cycles();
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Вы ввели неверное число");
                            Console.ResetColor();
                        }

                    }
                    else if (y == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{x}, вы находитесь в разделе 'Работа с условными конструкторами'");
                        Console.WriteLine();
                        Console.WriteLine("Выберите задачу, с которой вы бы хотели поработать:\n1 - Напишите консольную программу, " +
                            "в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа " +
                            "выводит 'Число больше 5 и меньше 10'. Иначе программа выводит сообщение 'Неизвестное число'.\n2 - " +
                            "Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, " +
                            "то программа выводит 'Число либо равно 5, либо равно 10'. Иначе программа выводит сообщение 'Неизвестное число'.\n3 - " +
                            "В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, " +
                            "в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, " +
                            "то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.\n4 - " +
                            "Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк " +
                            "решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.\n5 - " +
                            "Напишите консольную программу, которая выводит пользователю сообщение 'Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение'. " +
                            "Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в " +
                            "зависимости от номера операции программа выводит ему название операции.\n6 - " +
                            "Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с " +
                            "введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.\n7 - " +
                            "Калькулятор\n8 - Конвертер времени\n9 - Конвертер валют\n0 - возврат в прерыдущее меню");
                        Console.WriteLine();
                        int u = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.ResetColor();

                        if (u == 0)
                        {
                            break;
                        }
                        if (u == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_1();
                            Console.ResetColor();
                        }
                        else if (u == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_2();
                            Console.ResetColor();
                        }
                        else if (u == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_3();
                            Console.ResetColor();
                        }
                        else if (u == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_4();
                            Console.ResetColor();
                        }
                        else if (u == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_5();
                            Console.ResetColor();
                        }
                        else if (u == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            conditional_constructors_6();
                            Console.ResetColor();
                        }
                        else if (u == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            calculator();
                            Console.ResetColor();
                        }
                        else if (u == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            time_converter();
                            Console.ResetColor();
                        }
                        else if (u == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            currency_converter();
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Вы ввели неверное число");
                            Console.ResetColor();
                        }
                    }
                    else if (y == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{x}, вы находитесь в разделе 'Массивы', для возврата в предыдщуее меню нажмите 0, для продолжения нажмите 1");
                        int o = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (o == 0)
                        {
                            break;
                        }
                        massiv();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вы ввели неверное число");
                        Console.ResetColor();
                    }
                }
                
            }
            while (n != "да");
        }



        static void logical_operations()
        {
            int p1 = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите данные числа x: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите данные числа y: ");
                int p2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Выберите действие:\n1 - логическая конъюнкция\n2 - логическая дезъюнкция\n3 - логическая исключающая 'или'" +
                    "\n4 - операция отрицания\n0 - возврат в прерыдущее меню");
                Console.WriteLine();
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                if (t1 == 0)
                {
                    break;
                }
                while (true)
                {
                    if (t1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z = p & p2;
                        Console.WriteLine($"Вычисление логической конъюнкции: x & y = {z}");
                        Console.ResetColor();
                    }
                    else if (t1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z1 = p | p2;
                        Console.WriteLine($"Вычисление логической дезъюнкции: x | y = {z1}");
                        Console.ResetColor();
                    }
                    else if (t1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z2 = p ^ p2;
                        Console.WriteLine($"Вычисление логической исключающей 'или': x ^ y = {z2}");
                        Console.ResetColor();
                    }
                    else if (t1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z3 = ~p;
                        int z4 = ~p2;
                        Console.WriteLine($"Вычисление операции отрицания: ~x = {z3}\n\t\t\t       ~y = {z4}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Вы ввели неверное число");
                        Console.ResetColor();
                    }
                }
            }
            while (p1 != 0);
           
        }

        static void arithmetic_operations()
        {
            int r = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите данные числа x: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите данные числа y: ");
                int p2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Выберите действие:\n1 - сложить\n2 - вычесть\n3 - умножить 'или'" +
                    "\n4 - поделить\n5 - поделить по модулю\n0 - возврат в прерыдущее меню");
                Console.WriteLine();
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                if (t1 == 0)
                {
                    break;
                }
                while (true)
                {
                    if (t1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z = p + p2;
                        Console.WriteLine($"x + y = {z}");
                        Console.ResetColor();
                    }
                    else if (t1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z1 = p - p2;
                        Console.WriteLine($"x - y = {z1}");
                        Console.ResetColor();
                    }
                    else if (t1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z2 = p * p2;
                        Console.WriteLine($"x * y = {z2}");
                        Console.ResetColor();
                    }
                    else if (t1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z3 = p / p2;
                        Console.WriteLine($"x : y = {z3}");
                        Console.ResetColor();
                    }
                    else if (t1 == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int z4 = p % p2;
                        Console.WriteLine($"x % y = {z4}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Вы ввели неверное число");
                        Console.ResetColor();
                    }
                }
            }
            while (r != 0);
        }

        static void comparison_operations()
        {
            int r = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите данные числа x: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите данные числа y: ");
                int p2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Выберите действие:\n1 - сравнить два числа\n0 - возврат в прерыдущее меню");
                Console.WriteLine();
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                if (t1 == 0)
                {
                    break;
                }
                while (true)
                {
                    if (t1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        bool c1 = p == p2;
                        Console.WriteLine($"Равенство a и b: {c1}");

                        bool c2 = p != p2;
                        Console.WriteLine($"Неравенство a и b: {c2}");

                        bool c3 = p > p2;
                        Console.WriteLine($"a больше b: {c3}");

                        bool c4 = p < p2;
                        Console.WriteLine($"a меньше b: {c4}");

                        bool c5 = p >= p2;
                        Console.WriteLine($"a больше или равно b: {c5}");

                        bool c6 = p <= p2;
                        Console.WriteLine($"a меньше или равно b: {c6}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Вы ввели неверное число");
                        Console.ResetColor();
                    }
                } 
            }
            while (r != 0);
        }

        static void cycles()
        {
            int p = 0;
            do
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Выберите задачу:\n1 - В стране XYZ население равно 10 миллионов человек. " +
                    "Рождаемость составляет 14 человек на 1000 человек, смертность - 8 человек. " +
                    "Рассчитайте, какая численность населения будет через 10 лет, принимая во внимание, что показатели рождаемости и смертности постоянны.\n2 - " +
                    "В стране XYZ население равно 10 миллионов человек. Рождаемость составляет 14 человек на 1000 человек, смертность - 8 человек. " +
                    "Каждый год рождается и умирает на 1 человек, меньше чем в предыдущий год. " +
                    "Рассчитайте, какая численность населения будет через 10 лет, учитывая, что рождаемость не может быть меньше 7 человек на 1000 человек, " +
                    "а смертностность не может быть меньше 6 человек на 1000 человек.\n3 - " +
                    "За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. " +
                    "А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.\n4 - " +
                    "В цикле программа просит у пользователя ввести два числа и выводит результат их умножения. " +
                    "После вывода результата умножения программа спрашивает, надо ли завершить выполнение. И если пользователь введет число 1, то программа завершает цикл. " +
                    "Если введено любое другое число, то программа продолжает спрашивать у пользователя два числа и умножать их.\n5 - " +
                    "Треугольник высотой N\n6 - Ряд Фибоначи\n0 - возврат в прерыдущее меню");
                Console.WriteLine();
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                    if (t1 == 0)
                    {
                        break;
                    }
                    if (t1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_1();
                        Console.ResetColor();
                    }
                    else if (t1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_2();
                        Console.ResetColor();
                    }
                    else if (t1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_3();
                        Console.ResetColor();
                    }
                    else if (t1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_4();
                        Console.ResetColor();
                    }
                    else if (t1 == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_5();
                        Console.ResetColor();
                    }
                    else if (t1 == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        cyclec_6();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Вы ввели неверное число");
                        Console.ResetColor();
                    }
                }
            }
            while (p != 0);
        }

        static void cyclec_1()
        {
            while (true)
            {
                Console.WriteLine("Задача 1:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    int population = 10000000;
                    int born = 14;
                    int death = 8;
                    for (int i = 1; i <= 10; i++)
                    {
                        population += population * (born - death) / 1000;
                    }
                    Console.WriteLine($"Численность населения через 10 лет: {population}");
                }
                
            }
          
        }

        static void cyclec_2()
        {
            while (true)
            {
                Console.WriteLine("Задача 2:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    int population1 = 10000000;
                    int born1 = 14;
                    int death1 = 8;
                    for (int i = 1; i <= 10; i++)
                    {
                        if (born1 > 7) born1 -= 1;
                        if (death1 > 6) death1 -= 1;
                        population1 += population1 * (born1 - death1) / 1000;
                    }
                    Console.WriteLine($"Численность населения через 10 лет: {population1}");
                }
            }
           
        }

        static void cyclec_3()
        {
            while (true)
            {
                Console.WriteLine("Задача 3:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите сумму вклада: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите количество месяцев: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= y; i++)
                    {
                        x += x * 0.07;
                    }
                    Console.WriteLine($"После {y} месяцев сумма вклада составит {x}");
                }
            }

        }

        static void cyclec_4()
        {
            while (true)
            {
                Console.WriteLine("Задача 4:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    int n = 0;
                    do
                    {
                        Console.Write("Введите первое число: ");
                        double x2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        int y2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Результат умножения: {x2 * y2}");

                        Console.WriteLine();
                        Console.Write("Для выхода из программы нажмите '1', для продолжения - любую другую цифру: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    while (n != 1);
                }
            }
           
        }


        static void cyclec_5()
        {
            while (true)
            {
                Console.WriteLine("Треугольник высотой N:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите высоту треугольника: ");
                    int x3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int v, j;

                    for (v = 0; v < x3; v++)
                    {

                        for (j = x3 - v; j > 0; j--)
                            Console.Write(" ");

                        for (j = 0; j <= 2 * v; j++)
                            Console.Write("_");

                        Console.WriteLine();

                    }
                }
            }
        }
        static void cyclec_6()
        {
            while (true)
            {
                Console.WriteLine("Ряд чисел Фибоначи");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    int fib1 = 1;
                    int fib2 = 1;
                    Console.Write("Введите номер элемента ряда Фибоначи: ");
                    int t = Convert.ToInt32(Console.ReadLine());

                    int i = 0;
                    while (i < t - 2) // поскольку значения первых двух элементов ряда Фибоначчи нам уже известны и вычисления начинаем с третьего,
                                      // количество проходов по телу цикла должно быть на 2 меньше значения t, то есть t - 2.
                    {
                        int fib_sum = fib1 + fib2; // складываем fib1 и fib2, присвоив результат переменной для временного хранения данных - fib_sum
                        fib1 = fib2; // переменной fib1 присвоить значение fib2
                        fib2 = fib_sum; // переменной fib2 присвоить значение fib_sum
                        i = i + 1;
                    }
                    Console.WriteLine($"Значение этого элемента: {fib2}");
                }
            }
 
        }

        static void conditional_constructors_1()
        {
            while (true)
            {
                Console.WriteLine("Задача 1:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите данные переменной a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 5 && a < 10)
                    {
                        Console.WriteLine($"Число {a} больше 5 и меньше 10");
                    }
                    else
                    {
                        Console.WriteLine("Неизвестное число");
                    }
                }
            }
                  
        }

        static void conditional_constructors_2()
        {
            while (true)
            {
                Console.WriteLine("Задача 2:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите данные переменной b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (b == 5 || b == 10)
                    {
                        Console.WriteLine($"Число {b} либо равно 5, либо равно 10");
                    }
                    else
                    {
                        Console.WriteLine("Неизвестное число");
                    }
                }
            }
            
        }

        static void conditional_constructors_3()
        {
            while (true)
            {
                Console.WriteLine("Задача 3:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите сумму вклада: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (deposit < 100 && deposit > 0)
                    {
                        if (deposit < 100 && deposit > 0)
                        {
                            int num = deposit % 10;
                            if (num == 1)
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit} рубль");
                            }
                            else if (num < 5 && num > 1)
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit} рубля");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit} рублей");
                            }

                        }
                    }
                    else if (deposit <= 200 && deposit >= 100)
                    {
                        if (deposit <= 200 && deposit >= 100)
                        {
                            int num = deposit % 10;
                            if (num == 1)
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit} рубль");
                            }
                            else if (num < 5 && num > 1)
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit} рубля");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit} рублей");
                            }

                        }
                    }
                    else
                    {
                        if (deposit > 200)
                        {
                            int num = deposit % 10;
                            if (num == 1)
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit} рубль");
                            }
                            else if (num < 5 && num > 1)
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit} рубля");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit} рублей");
                            }

                        }
                    }
                }
                
            }
           
        }
        static void conditional_constructors_4()
        {
            while (true)
            {
                Console.WriteLine("Задача 4:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите сумму вклада: ");
                    int deposit1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (deposit1 < 100 && deposit1 > 0)
                    {
                        if (deposit1 < 100 && deposit1 > 0)
                        {
                            int num1 = deposit1 % 10;
                            if (num1 == 1)
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit1} рубль, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else if (num1 < 5 && num1 > 1)
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit1} рубля, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 5% за вклад суммой {deposit1} рублей, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }

                        }
                    }
                    else if (deposit1 <= 200 && deposit1 >= 100)
                    {
                        if (deposit1 <= 200 && deposit1 >= 100)
                        {
                            int num1 = deposit1 % 10;
                            if (num1 == 1)
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit1} рубль, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else if (num1 < 5 && num1 > 1)
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit1} рубля, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 7% за вклад суммой {deposit1} рублей, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }

                        }
                    }
                    else
                    {
                        if (deposit1 > 200)
                        {
                            int num1 = deposit1 % 10;
                            if (num1 == 1)
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit1} рубль, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else if (num1 < 5 && num1 > 1)
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit1} рубля, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }
                            else
                            {
                                Console.WriteLine($"Вам начислились 10% за вклад суммой {deposit1} рублей, так же, с учетом бонусов, нам вашем счету теперь {deposit1 + 15}");
                            }

                        }
                    }
                }
            }  
        }
        static void conditional_constructors_5()
        {
            while (true)
            {
                Console.WriteLine("Задача 5:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите номер операции: 1) Вычитание, 2) Сложение, 3) Умножение");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Операция вычитания");
                            break;
                        case 2:
                            Console.WriteLine("Операция сложения");
                            break;
                        case 3:
                            Console.WriteLine("Операция умножения");
                            break;
                    }
                }
            }
        }
        static void conditional_constructors_6()
        {
            while (true)
            {
                Console.WriteLine("Задача 6:");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите первое число: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите номер операции: 1) Вычитание, 2) Сложение, 3) Умножение");
                    int c1 = Convert.ToInt32(Console.ReadLine());
                    int u1 = first * second;
                    int u2 = first + second;
                    int u3 = first - second;
                    switch (c1)
                    {
                        case 1:
                            Console.WriteLine($"Операция вычитания: {u3}");
                            break;
                        case 2:
                            Console.WriteLine($"Операция сложения: {u2}");
                            break;
                        case 3:
                            Console.WriteLine($"Операция умножения: {u1}");
                            break;
                    }
                }
            }
        }
        static void calculator()
        {
            while (true)
            {
                Console.WriteLine("Калькулятор");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите первое число: ");
                    double first1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double second1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите номер операции: 1) Вычитание, 2) Сложение, 3) Умножение, 4) Деление");
                    double c12 = Convert.ToInt32(Console.ReadLine());
                    double u12 = first1 * second1;
                    double u22 = first1 + second1;
                    double u32 = first1 - second1;
                    double u42 = first1 / second1;
                    switch (c12)
                    {
                        case 1:
                            Console.WriteLine($"Операция вычитания: {u32}");
                            break;
                        case 2:
                            Console.WriteLine($"Операция сложения: {u22}");
                            break;
                        case 3:
                            Console.WriteLine($"Операция умножения: {u12}");
                            break;
                        case 4:
                            Console.WriteLine($"Операция деления: {u42}");
                            break;
                    }
                }
            } 
        }
        static void time_converter()
        {
            while (true)
            {
                Console.WriteLine("Конвертер времени");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите количество секунд: ");
                    int s = Convert.ToInt32(Console.ReadLine());
                    long year = s / 365 / 86400;
                    long modul_year = s % (year * 365 * 86400);
                    long month = modul_year / 30 / 86400;
                    long modul_month = modul_year % (month * 30 * 86400);
                    long day = modul_month / 86400;
                    long modul_day = modul_month % (day * 86400);
                    long hour = modul_day / 3600;
                    long modul_hour = modul_day % (hour * 3600);
                    long min = modul_hour / 60;
                    long sec = modul_hour % 60;

                    if (year <= 10)
                    {
                        if (year % 10 == 1)
                        {
                            if (year % 100 == 11)
                            {
                                Console.Write($"{year} лет ");
                            }
                            else
                            {
                                Console.Write($"{year} год ");
                            }

                        }
                        else if (year % 10 == 2 || year % 10 == 3 || year % 10 == 4)
                        {
                            if (year % 100 == 12 || year % 100 == 13 || year % 100 == 14)
                            {
                                Console.Write($"{year} лет ");
                            }
                            else
                            {
                                Console.Write($"{year} года ");
                            }
                        }
                        else
                        {
                            Console.Write($"{year} лет ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Года выходят за переделы допустимого значения");
                    }

                    //----------------------------------------------------------------------------------------------------

                    if (month % 10 == 1)
                    {
                        if (month % 100 == 11)
                        {
                            Console.Write($"{month} месяцев ");
                        }
                        else
                        {
                            Console.Write($"{month} месяц ");
                        }
                    }
                    else if (month % 10 == 2 || month % 10 == 3 || month % 10 == 4)
                    {
                        if (month % 100 == 12 || month % 100 == 13 || month % 100 == 14)
                        {
                            Console.Write($"{month} месяцев ");
                        }
                        else
                        {
                            Console.Write($"{month} месяца ");
                        }
                    }
                    else
                    {
                        Console.Write($"{month} месяцев ");
                    }

                    //----------------------------------------------------------------------------------------------------

                    if (day % 10 == 1)
                    {
                        if (day % 100 == 11)
                        {
                            Console.Write($"{day} дней ");
                        }
                        else
                        {
                            Console.Write($"{day} день ");
                        }
                    }
                    else if (day % 10 == 2 || day % 10 == 3 || day % 10 == 4)
                    {
                        if (day % 100 == 12 || day % 100 == 13 || day % 100 == 14)
                        {
                            Console.Write($"{day} дней ");
                        }
                        else
                        {
                            Console.Write($"{day} дня ");
                        }
                    }
                    else
                    {
                        Console.Write($"{day} дней ");
                    }

                    //----------------------------------------------------------------------------------------------------

                    if (hour % 10 == 1)
                    {
                        if (hour % 100 == 11)
                        {
                            Console.Write($"{hour} часов ");
                        }
                        else
                        {
                            Console.Write($"{hour} час ");
                        }
                    }
                    else if (hour % 10 == 2 || hour % 10 == 3 || hour % 10 == 4)
                    {
                        if (hour % 100 == 12 || hour % 100 == 13 || hour % 100 == 14)
                        {
                            Console.Write($"{hour} часов ");
                        }
                        else
                        {
                            Console.Write($"{hour} часа ");
                        }
                    }
                    else
                    {
                        Console.Write($"{hour} часов ");
                    }

                    //----------------------------------------------------------------------------------------------------

                    if (min % 10 == 1)
                    {
                        if (min % 100 == 11)
                        {
                            Console.Write($"{min} минут ");
                        }
                        else
                        {
                            Console.Write($"{min} минута ");
                        }
                    }
                    else if (min % 10 == 2 || min % 10 == 3 || min % 10 == 4)
                    {
                        if (min % 100 == 12 || min % 100 == 13 || min % 100 == 14)
                        {
                            Console.Write($"{min} минут ");
                        }
                        else
                        {
                            Console.Write($"{min} минуты ");
                        }
                    }
                    else
                    {
                        Console.Write($"{min} минут ");
                    }

                    //----------------------------------------------------------------------------------------------------

                    if (sec % 10 == 1)
                    {
                        if (sec % 100 == 11)
                        {
                            Console.Write($"{sec} секунд");
                        }
                        else
                        {
                            Console.Write($"{sec} секунда");
                        }
                    }
                    else if (sec % 10 == 2 || sec % 10 == 3 || sec % 10 == 4)
                    {
                        if (sec % 100 == 12 || sec % 100 == 13 || sec % 100 == 14)
                        {
                            Console.Write($"{sec} секунд");
                        }
                        else
                        {
                            Console.Write($"{sec} секунды");
                        }
                    }
                    else
                    {
                        Console.Write($"{sec} секунд");
                    }

                    Console.WriteLine();
                }
            }
        }

        static void currency_converter()
        {
            while (true)
            {
                Console.WriteLine("Конвертер валют");
                Console.WriteLine();
                Console.WriteLine("Для возврата в предыдщуее меню нажмите 0, чтобы продолжить нажмите 1");
                int e = Convert.ToInt32(Console.ReadLine());

                if (e == 0)
                {
                    break;
                }
                else
                {
                    int euro = 92;
                    int dollar = 73;
                    Console.Write("Введите сумму в рублях: ");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите код валюты: 400 - доллары, 401 - евро: ");
                    int choose2 = Convert.ToInt32(Console.ReadLine());

                    if (choose2 == 400)
                    {
                        int result = choose / dollar;
                        if (result % 10 == 1)
                        {
                            if (result % 100 == 11)
                            {
                                Console.WriteLine($"К выдаче: {result} долларов");
                            }
                            else
                            {
                                Console.WriteLine($"К выдаче: {result} доллар");
                            }

                        }
                        else if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
                        {
                            if (result % 100 == 12 || result % 100 == 13 || result % 100 == 14)
                            {
                                Console.WriteLine($"К выдаче: {result} долларов");
                            }
                            else
                            {
                                Console.WriteLine($"К выдаче: {result} доллара");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"К выдаче: {result} долларов");
                        }

                    }
                    else if (choose2 == 401)
                    {
                        int result2 = choose / euro;
                        Console.WriteLine($"К выдаче: {result2} евро");
                    }
                    else
                    {
                        Console.WriteLine("Неккоректно введенные данные");
                    }
                }
            } 
        }
        static void massiv()
        {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Создайте массив");
                Console.WriteLine();
                    Console.Write("Введите длину массива: ");
                    int lengs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите высоту массива: ");
                    int hight = Convert.ToInt32(Console.ReadLine());
                    string tab = "\t\t\t\t";
                    string[,] numbers3 = new string[lengs, hight];
                    for (int i = 0; i < lengs; i++)
                    {
                        Console.Write($"{tab}");
                        for (int j = 0; j < hight; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            numbers3[i, j] = "_";
                            Console.Write($"{numbers3[i, j]}\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                        Console.ResetColor();
                    }
                
            
        }
    }
}

