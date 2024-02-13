public class Circle : Shape
{

    private double _radius;
    public Circle(string color, double radius):base(color){
        this._radius = radius;
    }
    public override double GetArea(){
        double myPi = Math.PI;
        return myPi * _radius * _radius;
    }
    public double GetRadius(){
        return _radius;
    }
    public void SetRadius(double radius){
        this._radius = radius;
    }
}