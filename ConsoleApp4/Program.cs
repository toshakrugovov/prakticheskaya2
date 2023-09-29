




static void ugadai_chislo()
{
    Console.WriteLine(" Игра 'Угадай число' от 0 до 100");
    Console.WriteLine("Введите число: ");
    Random rnd = new Random();
    int value = rnd.Next(0, 100);



    while(true)
    {
        int x = Convert.ToInt32((Console.ReadLine()));
        if (x < value)
        {
            Console.WriteLine("Рандомное число больше");


        }

        else if (x > value)
        {

            Console.WriteLine("Рандомное число меньше");
        }
        if (x == value)
        {
            Console.WriteLine("Вы угадали число!!! ЮХУУУ!!!");
            break;

        }


        
    }


    
}

static void tablica_umnoshenia()

{

    Console.WriteLine("\n        1\t2\t3\t4\t5\t6\t7\t8\t9");
    Console.WriteLine();
    for (int i = 1; i < 10; i++)
    {
        Console.Write(i);
        for (int j = 1; j < 10; j++)
        {
            Console.Write("\t" + i * j);
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }



}

static void deliteli()
{

    Console.Write("Введите число: ");
    int i = int.Parse(Console.ReadLine());
    for (int a = 1; a * a < i; a++)
    {
        if (i % a == 0) { Console.Write("{0} {1} ", a, i / a); }
    }
}




    while (true)
    {
    Console.WriteLine("  ");
    Console.WriteLine("Меню");
        Console.WriteLine("1. Игра 'Угадай число' ");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Закрыть программу");

        int point = 1;
        string caseSwicth = Console.ReadLine();
        int bu = Convert.ToInt32(caseSwicth);

        if (bu == 1)
        {
            ugadai_chislo();
        
        }
        else if (bu == 2)
        {
            tablica_umnoshenia();
        }
        else if (bu==3)
        {
        deliteli();
        }
        else if (bu == 4)
        {
            Console.WriteLine("Вы вышли из программы!");
            break;
        }

    }