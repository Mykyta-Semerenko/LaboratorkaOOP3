using System;


class Point
{
    public int x, y, p;


    public Point(int x1, int y1)
    {
        x = x1;
        y = y1;
        p = Perimeter();
    }


    public int Perimeter()
    {
        return 2 * (Math.Abs(x) + Math.Abs(y));
    }


    public string Info()
    {
        return $"Точка ({x}, {y})";
    }
}


class Program
{
    static void Result(int n, Point p)
    {
        string format =
            "Точка {0}: {1}, периметр прямокутника = {2}";


        Console.WriteLine(format, n, p.Info(), p.p);
    }


    static void Main()
    {
        Point p1 = new Point(4, 6);
        Point p2 = new Point(3, 8);


        Result(1, p1);
        Result(2, p2);


        Console.ReadLine();
    }
}