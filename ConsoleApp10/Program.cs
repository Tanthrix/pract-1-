while (true)
{
    tekst();
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("Введите значения двух переменных: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine(b + c);
            break;
        case 2:
            d2();
            break;
        case 3:
            d3();
            break;
        case 4:
            d4();
            break;
        case 5:
            d5();
            break;
        case 6:
            d6();
            break;
        case 7:
            d7();
            break;
        case 8:
            d8();
            break;
        case 9:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("");
            break;
    }
    static void tekst()
    {
        Thread.Sleep(5000);
        Console.Clear();
        Console.WriteLine("1 + ");
        Console.WriteLine("2 - ");
        Console.WriteLine("3 * ");
        Console.WriteLine("4 / ");
        Console.WriteLine("5 степень ");
        Console.WriteLine("6 квадрат корень");
        Console.WriteLine("7 1%");
        Console.WriteLine("8 факториал");
        Console.WriteLine("9 выход");
    }
    static void d2()
    {
        Console.WriteLine("Введите значения двух переменных: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(b - c);
    }

    static void d3()
    {
        Console.WriteLine("Введите значения двух переменных: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(b * c);
    }
    static void d4()
    {
        Console.WriteLine("Введите значения двух переменных: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (c == 0)
            Console.WriteLine("на 0 делить нельзя");
        else
        Console.WriteLine(b / c);
    }
    static void d5()
    {
        Console.WriteLine("Введите значения двух переменных: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(b, c));
    }
    static void d6()
    {
        Console.WriteLine("Введите значение переменной: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (b<0)
            Console.WriteLine("Корня из отрицательного числа нет");
        else
        Console.WriteLine(Math.Sqrt(b));
    }
    static void d7()
    {
        Console.WriteLine("Введите значение переменной ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(b / 100);
    }
    static void d8()
    {   Console.WriteLine("Введите значение переменной: ");
        int b = Convert.ToInt32(Console.ReadLine());
        double res;
        if (b < 0)
        {
            Console.WriteLine("Попытка получения факториала отрицательного числа");
           
        }
        else if (b == 0)
        {
            Console.WriteLine("0");
            
        }
        res = 1;
        for (int i = 1; i <= b; i++)
        {
            res *= i;
        }
        Console.WriteLine(res);
        
    }
}