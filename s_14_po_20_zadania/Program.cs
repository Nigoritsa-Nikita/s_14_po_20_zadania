
//14__(по месяцу и числу определить какой день недели в 2024)
/**
using System;
class Program
{
    static void Main()
    {
        int d = 1, f = 28, g = 2024;
        if (g % 4 == 0)
            f = 29;
        int month = 0, date = 0, tOtsceta = d - 1;
        int[] array = new int[] { 31, f, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        try
        {
            Console.WriteLine("месяц:");
            month = Convert.ToInt32(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка! номер месяца должен находиться в отрезке [1;12]");
                Main();
            }
            Console.WriteLine("число:");
            date = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ошибка!");
            Main();
        }
        if (date > array[month - 1] || date < 1)
        {
            Console.WriteLine("Ошибка! в этом месяце не может быть столько дней");
            Main();
        }
        for (int i = 0; i < month - 1; i++)
            tOtsceta += array[i];
        tOtsceta += date;
        Console.WriteLine("День недели:");
        switch (tOtsceta % 7)
        {
            case 1:
                Console.WriteLine("ПН");
                break;
            case 2:
                Console.WriteLine("ВТ");
                break;
            case 3:
                Console.WriteLine("СР");
                break;
            case 4:
                Console.WriteLine("ЧТ");
                break;
            case 5:
                Console.WriteLine("ПТ");
                break;
            case 6:
                Console.WriteLine("СБ");
                break;
            case 0:
                Console.WriteLine("ВС");
                break;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nttttttttttttttttttttttttttttttttttttttttttttt");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        if (povtor == "")
            Main();
    }
}
/**/

//15__(умножать повтор.эл.массива на их индексы, пока все эл.массива не станут различными)
/**
using System;
class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 20, p = 0, pp = 0;
        bool flag;
        int[] array = new int[a];
        for (int i = 0; i < array.Length; i++)
            Console.Write("{0,3}", i);
        Console.WriteLine("   - индексы");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = r.Next(1, 10);
            Console.Write("{0,3}", array[i]);
        }
        Console.WriteLine("   - исходный массив");
        for (int i = 0; i < array.Length; i++)
        {
            p = 0;
            if (i == 1)
            {
                p = 1;
                if (array[0] == array[1]) pp = 1;
            }
            flag = true;
            for (int j = 0; j < i; j++)
                if (array[i] == array[j] && p != 1)
                {
                    array[i] *= i;
                    i--;
                    flag = false;
                    break;
                }
            if (flag)
            {
                if (array[i] > 99)
                    Console.Write("  ");
                Console.Write("{0,3}", array[i]);
            }
        }
        Console.WriteLine("   - изменённый массив");
        if (pp == 1)
            Console.WriteLine("если умножать элемент под индексом 1, то он не изменится, поэтому эллемент под индексом 1 не изменился");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nttttttttttttttttttttttttttttttttttttttttttttt");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        Console.ForegroundColor = ConsoleColor.White;
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}
/**/

//16__(найти самую длинную цепочку цепочку из одинак.чисел, вывести знач.эл., длину цеп., нач.инд. массив  1000 эл. ранд от 1 до 6)
/**
using System;
class Program
{
    static void Main()
    {
        Random r = new Random();
        int[] array = new int[1000];
        int endIndAdd1 = 0, length = 0, valueEl = 0, number = 1;
        array[0] = r.Next(1, 7);
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = r.Next(1, 7);
            if (array[i] == array[i - 1] || i == array.Length - 1)
            {
                number++;
                if (i == array.Length - 1 && number >= length)
                {
                    length = number;
                    endIndAdd1 = i + 1;
                    valueEl = array[i - 1];
                }
            }
            else
            {
                if (number >= length)
                {
                    length = number;
                    endIndAdd1 = i;
                    valueEl = array[i - 1];
                }
                number = 1;
            }
        }
        Console.WriteLine("длина цепочки: {0}", length);
        Console.WriteLine("инд.нач.эл.: {0}", endIndAdd1 - length);
        Console.WriteLine("его знач.: <{0}>", valueEl);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nttttttttttttttttttttttttttttttttttttttttttttt");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        if (povtor == "")
            Main();
    }
}
/**/

//17__(4501 --> 1045(Составить минимальное число из цифр данного натурального числа))
/**
using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            int number1 = 0, number2 = 0, quantityDigit = 1, quantityZero = 0, b;
            Console.WriteLine("Введите натур число:");
            try
            {
                number1 = number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка!");
                continue;
            }
            if (number1 < 0)
            {
                Console.WriteLine("Ошибка! число должно быть натуральным");
                continue;
            }
            while (number1 / 10 != 0)
            {
                quantityDigit++;
                number1 /= 10;
            }
            number1 = number2;
            int[] array = new int[quantityDigit];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number1 % 10;
                number1 /= 10;
                if (array[i] == 0)
                    quantityZero++;
            }
            Array.Sort(array);
            if (number2 != 0)
            {
                b = array[quantityZero];
                array[quantityZero] = array[0];
                array[0] = b;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            string proverka = Convert.ToString(Console.ReadLine());
            if (proverka != "")
                break;
        }
    }
}
/**/

//18__(вывести окантовку массива)
/**
using System;
class Program
{
    static void Main()
    {
        Random r = new Random();
        int n = 5, m = 7;
        int[,] array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)           
                Console.Write("{0,3}", array[i, j] = r.Next(0,10));           
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    Console.Write("{0,3}", array[i, j]);
                else 
                    Console.Write("{0,3}","");
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        string proverka = Convert.ToString(Console.ReadLine());
        if (proverka == "")
            Main();
    }
}
/**/

//19__(Заполнить в матрице n на n главную диоганаль номерами строки, побочную номерами столбца)
/**
using System;
class Program
{
    static void Main()
    {
        int n = 5, jj = n - 1;
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                if (i == j)
                    Console.Write("{0,2}", array[i, j] = i);
                else
                    if (j == jj)
                    Console.Write("{0,2}", array[i, j] = j);
                else
                    Console.Write("{0,2}", array[i, j]);
            jj--;
            Console.WriteLine();
        }
        Console.WriteLine("Для закрытия программы нажмите любую клавишу");
        Console.ReadKey();
    }
}
/**/

//20__(посчитать на какой раз сгенерируется магический квадрат(3 на 3))
/**
using System;
class Program
{
    static void Main()
    {
        Random r = new Random();
        int n = 3, line = 0, line1 = 0, column = 0, mainDioganal = 0, secondaryDioganal = 0, number = 0;
        int[,] array = new int[n, n];
        while (true)
        {
            number++;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    array[i, j] = 0;
            for (int i = 0; i < n; i++)           
                for (int j = 0; j < n; j++)
                    while (true)
                    {
                        array[i, j] = r.Next(1, 10);
                        if (i == 0 && j == 0)
                            break;
                        int k = 0;
                        for (int q = 0; q < n; q++)
                            for (int w = 0; w < n; w++)
                                if (array[q, w] == array[i, j])
                                    k++;
                        if (k == 1)
                            break;
                    }
            int p = 0;
            line1 = 0;
            for (int j = 0; j < n; j++)
                line1 += array[0, j];
            mainDioganal = 0;
            secondaryDioganal = 0;
            for (int i = 0; i < n; i++)
            {
                line = 0;
                column = 0;               
                for (int j = 0; j < n; j++)
                {
                    line += array[i, j];
                    column += array[j, i];                   
                }
                if (line != line1 || column != line1)
                {
                    p = 1;
                    break;
                }
                mainDioganal += array[i, i];
                secondaryDioganal += array[i, n - 1 - i];
            }
            if (mainDioganal != line1 || secondaryDioganal != line1)           
                p = 1;           
            if (p == 1)
                continue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,3}", array[i,j]);
                Console.WriteLine();
            }
            Console.WriteLine("  Магический квадрат был сгенерирован на {0}-й раз", number);
            break;
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        string proverka = Convert.ToString(Console.ReadLine());
        if (proverka == "")
            Main();
    }
}
/**/