using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
   
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
        Console.WriteLine("New entry added!!!");
    }
    public void DisplayAll(){
        foreach (Entry item in _entries)
        {
            item.Display();
            Console.WriteLine("");
        }
    }
    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in _entries)
            {
             outputFile.WriteLine($"{entry._date}#,{entry._promptText}#,{entry._entryText}");   
            }
        }
        Console.WriteLine("New file Saved!!!");
    }
    public void LoadFromFile(string fileName){
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry en = new Entry();
            string[] parts = line.Split("#,");
            en._date = parts[0];
            en._promptText = parts[1];
            en._entryText = parts[2];
            _entries.Add(en);
        }
        Console.WriteLine("New file loaded!!!");
    }
}