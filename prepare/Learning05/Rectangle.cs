public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width):base(color){
        this._length = length;
        this._width = width;
    }
    public override double GetArea(){
        return _length * _width;
    }
    public double GetLength(){
        return _length;
    }
    public void SetWidth(double width){
        this._width = width;
    }
    public double GetWidth(){
        return _width;
    }
    public void SetLength(double length){
        this._length = length;
    }
}