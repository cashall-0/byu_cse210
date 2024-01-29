public class Scripture
{
    public static List<int> availableInd  = new List<int>();
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        this._reference = reference;
        this._words  = new List<Word>();
        Word word;
        foreach (string item in text.Split(" "))
        {
            word = new Word(item);
            _words.Add(word);
        }
    }

    public void HideRandomWords(List<int> wordIndexes){
        int num;
        Random rnd = new Random();
            num = rnd.Next(0,_words.Count);
            while(wordIndexes.Contains(num)){
                num = rnd.Next(0,_words.Count);
            }
                wordIndexes.Add(num);
                _words[num].SetIsHidden(true);

    }
    public string GetDisplayText(){
        string disText = GetReference().GetDisplayText()+"  ";
        foreach (Word word in _words)
        {
             disText += word.GetDisplayText()+ " ";
        }
        return disText;
    }
    public bool IsCompletelyHidden(){
        foreach (Word item in _words)
        {
            if(!item.GetIsHidden()){
                return false; 
            }
        }
        return true;
    }

    public Reference GetReference(){
        return _reference;
    }
    public List<Word> GetWords(){
        return _words;
    }
    public void SetReference(Reference reference){
        this._reference = reference;
    }
    public void SetWords(List<Word> words){
        this._words = words;
    }
}