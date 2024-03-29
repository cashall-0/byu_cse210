using System.Runtime.InteropServices;

public abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        this._color = color;
    }
    public abstract double GetArea();

    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        this._color = color;
    }
}