public class Square : Shape
{
    private double _side;
    public Square(string color, double side):base(color){
        this._side = side;
    }
    public override double GetArea(){
        return _side* _side;
    }

    public double GetSide(){
        return _side;
    }
    public void SetSide(double side){
        this._side = side;
    }
}