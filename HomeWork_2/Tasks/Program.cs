/* Матущенко Наталья*/
using System;

namespace Task1
{
    class Program
    {

        static int Min_num(int a, int b, int c)
        {
            if (a < b && a < c) return a ;
            else
            {
                if (b < c && b < a) return b;
                else return c;
            }
        }
        static void Task_1()
        {
            Console.WriteLine("Задача 1: Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное из чисел:");
            
            Console.WriteLine(Min_num(a,b,c));
            Console.WriteLine("");
        }
        static void Task_2()
        {
            Console.WriteLine("Задача 2: Написать метод подсчета количества цифр числа.");
            Console.WriteLine("Введите число:");
            string z = Console.ReadLine();
            int ln = z.Length;
            int n = 0;

            while (ln != 0)
            {
                string ln1 = z.Substring(ln - 1, 1);
                int x = int.Parse(ln1);
                ln--;
                n = n + x;
            }
            Console.WriteLine(n);
            Console.WriteLine("");
        }
        static void Task_3()
        {
            Console.WriteLine("Задача 3: С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            int a;
            int n = 0;
            do
            {
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                if ((a % 2 != 0) && (a > 0)) n = n + a;
                else n = n;
                Console.WriteLine("Сумма нечетных введенных чисел: " + n + "\n");
            }
            while (a != 0);
            Console.WriteLine("");
        }
        static void Task_4()
        {
            Console.WriteLine("Задача 4: Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. \n  " +
                        "На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). \n " +
                        "Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. \n " +
                        "С помощью цикла do while ограничить ввод пароля тремя попытками.");
            string a;
            string b;
            int count = 0;
            int i = 0;
            int e = 0;
            do
            {
                Console.WriteLine("Введите логин:");
                a = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                b = Console.ReadLine();
                if ((a == "root") && (b == "GeekBrains")) i = 1;
                else i = 0;

                if (i == 1) Console.WriteLine("Доступ разрешен!");
                else Console.WriteLine("Логин или пароль не верный");

                count++;
                if (count == 3) Console.WriteLine("Попытки ввода логина/пароля закончились.");
                if ((count == 3) || (i == 1)) e = 1;
                else e = 0;
            }
            while (e != 1);
            Console.WriteLine("");
        }
        static void Task_5()
        {
            Console.WriteLine("Задача 5: \n" +
                "a) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме. \n " +
                "b)  Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.WriteLine("Укажите часть a или b желаете проверить:");
            string x = Console.ReadLine();

            if (x == "a") Task_5a();
            else
            {
                if (x == "b") Task_5b();
                else Console.WriteLine("Не верный номер части");
            }
            Console.WriteLine("");
        }
        static void Task_5a()
        {
            Console.WriteLine("Задача 5_a:");
            Console.WriteLine("Укажите ваш вес в кг:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш рост в см:");
            double h = double.Parse(Console.ReadLine()) / 100;
            double ii = m / (h * h);
            int i = Convert.ToInt32(ii);
            Console.WriteLine("Индекс массы тела: = " + i);
            if ((i >= 19) && (i <= 25)) Console.WriteLine("Ваш вес в норме");
            else
            {
                if (i < 19) Console.WriteLine("Необходимо набрать вес");
                else Console.WriteLine("Необходимо скинуть вес");
            }
            Console.WriteLine("");
        }

        static void Task_5b()
        {
            Console.WriteLine("Задача 5_b:");
            Console.WriteLine("Укажите ваш вес в кг:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите ваш рост в см:");
            double h = double.Parse(Console.ReadLine()) / 100;
            double ii = m / (h * h);
            int i = Convert.ToInt32(ii);
            Console.WriteLine("Индекс массы тела: = " + i);
            int refer_min = 19;
            int refer_max = 25;
            int ms = m;
            int count = 0;
            int r = i;
            //(it >= refer_min)&&(it <= refer_max);)
            if ((i >= refer_min) && (i <= refer_max)) Console.WriteLine("Ваш вес в норме");
            else
            {
                if (i < refer_min)
                {
                    while (r < refer_min)
                    {
                        count++;
                        ms++;
                        double ri = ms / (h * h);
                        r = Convert.ToInt32(ri);
                    }
                    Console.WriteLine("Необходимо набрать " + count + " кг");
                }
                else
                {
                    while (r > refer_max)
                    {
                        count++;
                        ms = ms - 1;
                        double ri = ms / (h * h);
                        r = Convert.ToInt32(ri);
                    }
                    Console.WriteLine("Необходимо скинуть " + count + " кг");
                };

            };
            Console.WriteLine("");
        }


        // Задача 6

        static void Task_gd_num(int min, int max)
        {
            int count_num = 0;
            while (min <= max)
            {
                int n2 = min, sum = 0;

                while (n2 > 0)
                {
                    sum = sum + n2 % 10;
                    n2 = n2 / 10;
                }
                if (min % sum == 0)
                { count_num = count_num + 1; }
                else { count_num = count_num; }
                min++;

            }
            Console.WriteLine("Сумма «хороших» чисел " + count_num);
        }
        static void Task_6()
        {
            Console.WriteLine("Задача 6: Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. \n" +
                "«Хорошим» называется число, которое делится на сумму своих цифр. \n" +
                "Реализовать подсчёт времени выполнения программы, используя структуру DateTime.\n");
            int min = 1;
            int max = 1000000000;
            int maxln = max.ToString().Length;
            Console.WriteLine("Начинаем подсчет, подождите.");
            var Date1 = DateTime.Now;
            Task_gd_num(min, max);
            var Date2 = DateTime.Now - Date1;
            Console.WriteLine("Время выполнения: " + Date2);

            Console.WriteLine("");
        }


        // Задача 7

        static void Task_7()
        {
            Console.WriteLine("Задача 7: \n" +
                "a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). \n" +
                "б) Разработать рекурсивный метод, который считает сумму чисел от a до b.");
            Console.WriteLine("Укажите часть a или b желаете проверить:");
            string x = Console.ReadLine();

            if (x == "a") Task_7a();
            else
            {
                if (x == "b") Task_7b();
                else Console.WriteLine("Не верный номер части");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void RecA(int a, int b)
        {
            Console.WriteLine(" " + a);
            if (a < b ) RecA(a + 1, b);
            
        }
        static int RecB(int a, int b)
        {
            if (a == b) return a;
            else return RecB(a, b - 1) + b;
        }
        static void Task_7a()
        {
            Console.WriteLine("Укажите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите число b:");
            int b = int.Parse(Console.ReadLine());
            RecA(a, b);
            Console.ReadKey();

        }
        static void Task_7b()
        {
            Console.WriteLine("Укажите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите число b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(RecB(a, b));
            Console.ReadKey();
        }

        // Итоговый вывод
        static void Main()
        {
            Console.SetWindowSize(150, 50);
            Console.SetBufferSize(150, 50);

            Console.WriteLine("Матущенко Наталья. Практическое задание 2.");
            int b;
            do
            {
                Console.WriteLine("Введите номер задачи от 1 до 7  \nИли введите 0 для выхода.");
                b = int.Parse(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Task_1();
                        break;
                    case 2:
                        Task_2();
                        break;
                    case 3:
                        Task_3();
                        break;
                    case 4:
                        Task_4();
                        break;
                    case 5:
                        Task_5();
                        break;
                    case 6:
                        Task_6();
                        break;
                    case 7:
                        Task_7();
                        break;
                }
            }
            while (b != 0);

            Console.WriteLine("Спасибо!");
            Console.ReadKey();




        }
    }
}
