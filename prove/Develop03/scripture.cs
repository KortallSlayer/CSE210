using System;
using System.ComponentModel;

class Scripture
{
    private List<Word> _words;

    Random _random = new Random();

    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _words = convertToWordList(text);

        
    }

    public void hideWord()
    {
        int RandomWord = _random.Next(0, _words.Count);
        _words[RandomWord].Hide();
    }
    


    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        
    }

    public void showScripture()
    {
        foreach(Word Word in _words)
        {
            Word.Display();
        }
    }
    

    private List<Word> convertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
}