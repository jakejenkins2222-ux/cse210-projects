using System;

public class Scripture
{

    private string _text;

    private List<Word> _words = new List<Word>();

    private Reference _reference;


    public Scripture(Reference reference, string text)
    {
        _text = text;
        _reference = reference;
    }


    public int MakeList()
    {
        string[] splitText = _text.Split(" ");

        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }

        return _words.Count();
    }

    

    public int HideWords()
    {
        Random randomGenerator = new Random();
        int hiddenCount = 0; 

    for (int i = 0; i < 3; i++)
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
                break;
            }
        }

        if (allHidden)
        {
            break;
        }

        bool canHide = false;
        int attempts = 0;

        while (!canHide)
        {
            int randomIndex = randomGenerator.Next(0, _words.Count);
            canHide = _words[randomIndex].HideWord();

            if (canHide)
            {
                hiddenCount++; 
            }

            attempts++;
            if (attempts >= 15)
            {
                foreach (Word word in _words)
                {
                    if (!word.IsHidden())
                    {
                        word.HideWord();
                        hiddenCount++;
                        canHide = true;
                        break;
                    }
                }
            }
        }
    }

    return hiddenCount;
}

    public int GetHiddenWordCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReference());

        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }

    }

    public void UnhideAllWords()
    {
        foreach (Word word in _words)
        {
            word.UnhideWord();
        }
    }


}




 
