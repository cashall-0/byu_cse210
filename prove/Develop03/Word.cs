public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        this._text = text;
        this._isHidden = false;
    }

    public void Hide(){
        SetIsHidden(true);
    }
    public void Show(){
        SetIsHidden(false);
    }
    public bool IsHidden(){
        return GetIsHidden();
    }
    public string GetDisplayText(){
        string returnText = "";
        for(int i=0;i<_text.Length;i++){
            returnText +="_";
        }
        if(_isHidden){
            return returnText;
        }
        return _text;
    }
    public string GetText(){
        return this._text;
    }
    public bool GetIsHidden(){
        return this._isHidden;
    }
    public void SetText(string text){
        this._text = text;
    }
    public void SetIsHidden(bool isHidden){
        this._isHidden = isHidden;
    }
}