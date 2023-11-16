using System;

namespace Тумаков_10лаб.Exercise_2
{
    public abstract class Figure
    {
        protected string color;
        protected bool visible;
    
    public Figure(string color, bool visible)
    {
        this.color = color;
        this.visible = visible;
    }
    
    public void MoveHorizontal(int distance)
    {

    }
    
    public void MoveVertical(int distance)
    {

    }
    
    public void ChangeColor(string newColor)
    {
        this.color = newColor;
    }
    
    public string GetVisibility()
    {
        return this.visible ? "Видимый" : "Невидимый";
    }
    
    public void Display()
    {
        Console.WriteLine("Цвет: " + this.color);
        Console.WriteLine("Состояние: " + this.GetVisibility());
    }

    }
}
