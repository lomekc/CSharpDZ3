void Palindrome(int pal)
{
    int revers = 0;
    int pal1 = pal;

    while (pal1 != 0)
    {
        revers = (revers * 10) + pal1 % 10;
        pal1 = pal1 / 10;
    }

    if (revers == pal)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}

void FindCube(int N)
{
    if (N < 0)
    {
        for (int i = 1; i >= N; i--)
        {
            int total = i * i * i;
            Console.Write(total + " ");
        }
    }
    else
    {
        for (int j = 1; j <= N; j++)
        {
            int totalj = j * j * j;
            Console.Write(totalj + " ");
        }
    }
}

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = (x2 - x1)*(x2 - x1);
    double y = (y2 - y1)*(y2 - y1);
    double z = (z2 - z1)*(z2 - z1);

    double distance = Math.Sqrt(x+y+z);
    return distance;
}


/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
*/
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов чисел от 1 до " + n + ": ");

FindCube(n);
*/
/*
Console.Write("Положение точки А. Введите значение координаты AХ: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение координаты AY: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение координаты AZ: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Положение точки В. Введите значение координаты BХ: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение координаты BY: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение координаты BZ: ");
double bz = Convert.ToDouble(Console.ReadLine());

double result = Distance3D(ax, ay, az, bx, by, bz);

Console.Write("расcтояние между точками A и B составляет " + result);
*/