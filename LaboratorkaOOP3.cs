using System;


class Rectangle
{
    private int x1, y1;
    private int x2, y2;
  
    public Rectangle(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    public int GetWidth()
    {
        return Math.Abs(x2 - x1);
    }
    public int GetHeight()
    {
        return Math.Abs(y1 - y2);
    }


  
    public int GetPerimeter()
    {
        return 2 * (GetWidth() + GetHeight());
    }


  
    public int GetArea()
    {
        return GetWidth() * GetHeight();
    }


  
    public void ShowCoordinates()
    {
        Console.WriteLine($"Верхній лівий кут: ({x1}, {y1})");
        Console.WriteLine($"Нижній правий кут: ({x2}, {y2})");


    
        Console.WriteLine($"Верхній правий кут: ({x2}, {y1})");
        Console.WriteLine($"Нижній лівий кут: ({x1}, {y2})");
    }
}


class LaboratorkaOOP3
{
    static void Main()
    {
        Rectangle rect = new Rectangle(2, 8, 7, 3);


        rect.ShowCoordinates();


        Console.WriteLine($"Ширина: {rect.GetWidth()}");
        Console.WriteLine($"Висота: {rect.GetHeight()}");
        Console.WriteLine($"Периметр: {rect.GetPerimeter()}");
        Console.WriteLine($"Площа: {rect.GetArea()}");
    }
}