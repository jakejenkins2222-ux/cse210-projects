using System;

public class Word
{
    private bool _hidden = false;
    private string _word;
    private string _originalWord;

    public Word(string word)
    {
        _word = word;
        _originalWord = word;
    }

    public bool HideWord()
    {
        if (_hidden == false)
        {
            _hidden = true;
            return true;
        }

        else
        {
            return false;
        }
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            return new string('_', _originalWord.Length);
        }
        else
        {
            return _originalWord;
        }
    }

    public void UnhideWord()
    {
        _hidden = false;
    }
}