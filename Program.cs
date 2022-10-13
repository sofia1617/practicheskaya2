internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите игру: \n1 - Рандомайзер\n2 - Таблица умножения\n3 - Вывод делителей числа\n4 - Выход");
            string vibor = Console.ReadLine();
            switch (vibor)
            {
                case "1":
                    abobus();
                    break;
                case "2":
                    abobus2();
                    break;
                case "3":
                    abobus3();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }
    static void abobus()
    {
        int a;
        Random randomchik = new Random();
        int randomchik2 = randomchik.Next(0, 101);
        do
        {
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < randomchik2)
            {
                Console.WriteLine("Введенное число меньше");
            }
            else if (a > randomchik2)
            {
                Console.WriteLine("Введенное число больше");
            }
            else
            {
                Console.WriteLine("УРА, ПОБЕДА!!!");
            }
        } while (a != randomchik2);
    }
    static void abobus2()
    {
        var tablichka = new int[10, 10];
        for (int i = 1; i < 10; ++i)
        {
            for (int a = 1; a < 10; ++a)
            {
                tablichka[i, a] = i * a;
            }
        }
        for (int i = 1; i < 10; ++i)
        {
            for (int a = 1; a < 10; ++a)
            {
                Console.Write("{0, 3}", tablichka[i, a]);
            }
            Console.WriteLine();
        }
    }
    static void abobus3()
    {
        Console.WriteLine("Введите число");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= b; i++)
        {
            if (b % i == 0)
            {
                Console.Write($"{i}    ");
            }
        }
        Console.WriteLine("");
    }
}