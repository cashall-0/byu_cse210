public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction(){
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int wholeNumber){
        this._top = wholeNumber;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom){
        this._top = top;
        this._bottom = bottom;
    }
    public int GetTop(){
        return _top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public void SetTop(int top){
        this._top = top;
    }
    public void SetTBottom(int bottom){
        this._bottom = bottom;
    }

    public String GetFractionString(){
        return _top.ToString() +"/"+ _bottom.ToString();
    }
    public double GetDecimalValue(){
        return (double) _top/_bottom;
    }
}