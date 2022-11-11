using System.ComponentModel;
using Торт_и_ки;


ConsoleKeyInfo key = Console.ReadKey();

int p = 3;
int a = 0;
Console.Clear();


while (true)
{
    Menu();
    Console.SetCursorPosition(0, p);
    Console.WriteLine("->");

    key = Console.ReadKey();

    if (key.Key == ConsoleKey.UpArrow)
    {
        p--;
    }

    if (key.Key == ConsoleKey.DownArrow)
    {
        p++;
    }

    if (p < 3)
    {
        p = 3;
    }

    if (p > 9)
    {
        p = 9;
    }
    Console.SetCursorPosition(0, p);
    Console.WriteLine("->");
    Console.Clear();
    
    if ((key.Key == ConsoleKey.Enter) & (p == 3))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            форма[] b = форма();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].forma + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].forma + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].forma + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 4))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            размер[] b = размер();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].razmer + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].razmer + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].razmer + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 5))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            вкус[] b = вкус();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].vkys + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].vkys + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].vkys + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 6))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            количество[] b =  количество();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].korj + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].korj + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].korj + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 7))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            глазурь[] b =  глазурь();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].glazyr + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].glazyr + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].glazyr + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 8))
    {

        ConsoleKeyInfo key1 = Console.ReadKey();
        int pos = 4;
        Console.Clear();
        while (key1.Key == ConsoleKey.UpArrow || key1.Key == ConsoleKey.DownArrow)
        {
            Menu2();
            декор[] b = декор();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key1 = Console.ReadKey();

            if (key1.Key == ConsoleKey.UpArrow)
            {
                pos--;
            }

            if (key1.Key == ConsoleKey.DownArrow)
            {
                pos++;
            }

            if (pos < 3)
            {
                pos = 3;
            }
            if (pos > 5)
            {
                pos = 5;
            }
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            Console.Clear();
            if (key1.Key == ConsoleKey.Escape)
            {
                break;
            }
            if (key1.Key == ConsoleKey.Enter && p == 3)
            {
                string txt = b[0].dekor + b[0].cena;
                a = a + b[0].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 4)
            {
                string txt = b[1].dekor + b[1].cena;
                a = a + b[1].cena;
            }
            if (key1.Key == ConsoleKey.Enter && p == 5)
            {
                string txt = b[2].dekor + b[2].cena;
                a = a + b[2].cena;
            }
        }


    }
    if ((key.Key == ConsoleKey.Enter) & (p == 9))
    {
        Console.Clear();
        Console.WriteLine("Спасибо за заказ. Если хотите сделать ещё один заказ, то нажмите Escape");
        File.WriteAllText("D:\\Рабочий стол\\История заказа.txt",txt);
        if (key.Key == ConsoleKey.Escape)
        { break;
        }
        else
        {
            break;
        }
    }

}
static void Menu()
{
    Console.WriteLine("Заказ тортов");
    Console.WriteLine("Выберите параметр торта");
    Console.WriteLine("- - - - - - - - - - - - - - ");
    Console.WriteLine("   Форма торта");
    Console.WriteLine("   Размер торта");
    Console.WriteLine("   Вкус коржей");
    Console.WriteLine("   Количество коржей");
    Console.WriteLine("   Глазурь");
    Console.WriteLine("   Декор");
    Console.WriteLine("   Конец заказа");
    Console.WriteLine("Цена заказа" + a);
}
static форма[] форма()
{
    форма krug = new форма();
    {
        krug.forma = "   Круг - ";
        krug.cena = 500;
    }
    Console.WriteLine(krug.forma + krug.cena);

    форма kvadrat = new форма();
    {
        kvadrat.forma = "   Квадрат - ";
        kvadrat.cena = 500;
    }
    Console.WriteLine(kvadrat.forma + kvadrat.cena);

    форма pryamoyg = new форма();
    {
        pryamoyg.forma = "   Прямоугольник - ";
        pryamoyg.cena = 500;
    }
    Console.WriteLine(pryamoyg.forma + pryamoyg.cena);

    форма[] формаs = new форма[] { krug, kvadrat, pryamoyg };
    return формаs;
}
static void Menu2()
{
    Console.WriteLine("Для выхода нажмите Escape");
    Console.WriteLine("Выберите пункт из меню: ");
    Console.WriteLine("- - - - - - - - - - - - - - ");
}
static размер[] размер()
{
    размер small = new размер();
    {
        small.razmer = "   Маленький (Диаметр - 16 см, 8 порций) - ";
        small.cena = 1000;
    }
    Console.WriteLine(small.razmer + small.cena);

    размер obich = new размер();
    {
        obich.razmer = "   Обычный (Диаметр - 18 см, 10 порций) - ";
        obich.cena = 1200;
    }
    Console.WriteLine(obich.razmer + obich.cena);

    размер big = new размер();
    {
        big.razmer = "   Большой (Диаметр - 28 см, 24 порций) - ";
        big.cena = 2000;
    }
    Console.WriteLine(big.razmer + big.cena);
    размер[] размерик = new размер[] { small, obich, big };
    return размерик;
}
static вкус[] вкус()
{
    вкус chok = new вкус();
    {
        chok.vkys = "   Шоколадный - ";
        chok.cena = 100;
    }
    Console.WriteLine(chok.vkys + chok.cena);

    вкус klub = new вкус();
    {
        klub.vkys = "   Клубничный - ";
        klub.cena = 1000;
    }
    Console.WriteLine(klub.vkys + klub.cena);

    вкус vanil = new вкус();
    {
        vanil.vkys = "   Ванильный - ";
        vanil.cena = 100;
    }
    Console.WriteLine(vanil.vkys + vanil.cena);

   вкус[] вкуси = new вкус[] { chok, klub, vanil };
    return вкуси;
}
static количество[] количество()
{
    количество odin = new количество();
    {
        odin.korj = "   Один коржик - ";
        odin.cena = 200;
    }
    Console.WriteLine(odin.korj + odin.cena);

    количество dva = new количество();
    {
        dva.korj = "   Два коржика - ";
        dva.cena = 400;
    }
    Console.WriteLine(dva.korj + dva.cena);

    количество tri = new количество();
    {
        tri.korj = "   Десять коржиков - ";
        tri.cena = 1000000;
    }
    Console.WriteLine(tri.korj + tri.cena);
    Console.WriteLine("Коржик, компот и карамелька");
    количество[] количествоs = new количество[] { odin, dva, tri };
    return количествоs;
}
static глазурь[] глазурь()
{
    глазурь chok = new глазурь();
    {
        chok.glazyr = "   Шоколад - ";
        chok.cena = 200;
    }
    Console.WriteLine(chok.glazyr + chok.cena);

    глазурь vanil = new глазурь();
    {
        vanil.glazyr = "   Ванилька - ";
        vanil.cena = 200;
    }
    Console.WriteLine(vanil.glazyr + vanil.cena);

    глазурь beze = new глазурь();
    {
        beze.glazyr = "   Я не слышу хруста безе - ";
        beze.cena = 10000;
    }
    Console.WriteLine(beze.glazyr + beze.cena);
    глазурь[] глаз = new глазурь[] { chok, vanil, beze};
    return глаз;
}
static декор[] декор()
{
    декор chok = new декор();
    {
        chok.dekor = "   Шоколадная - ";
        chok.cena = 400;
    }
    Console.WriteLine(chok.dekor + chok.cena);

    декор yagod = new декор();
    {
        yagod.dekor = "   Ягодная - ";
        yagod.cena = 500;
    }
    Console.WriteLine(yagod.dekor + yagod.cena);

    декор krem = new декор();
    {
        krem.dekor = "   Кремовая - ";
        krem.cena = 100;
    }
    Console.WriteLine(krem.dekor + krem.cena);
    декор[] декорчик = new декор[] { chok, yagod, krem };
    return декорчик;
}