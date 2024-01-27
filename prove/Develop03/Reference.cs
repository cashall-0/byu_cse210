public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = 0;
    }
    public Reference(string book, int chapter, int verse, int endVerse){
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText(){
        if(_endVerse == 0){
            return _book +" "+ _chapter +":"+ _verse;
        }
        return _book +" "+ _chapter +":"+ _verse +"-"+ _endVerse;
    }

    public void SetBook(string book){
        this._book = book;
    }
    public void SetVerse(int verse){
        this._verse = verse;
    }
    public void SetChapter(int chapter){
        this._chapter = chapter;
    }
    public void SetEndVerse(int endVerse){
        this._endVerse = endVerse;
    }
    public string GetBook(){
        return _book;
    }
    public int GetVerse(){
        return _verse;
    }
    public int GetChapter(){
        return _chapter;
    }
    public int GetEndVerse(){
        return _endVerse;
    }
}