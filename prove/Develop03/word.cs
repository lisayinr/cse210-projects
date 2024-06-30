using System;
class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenText;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _hiddenText = "";
        foreach (char letter in text)
        {
            _hiddenText += "_";
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return _hiddenText;
        }
        else
        {
            return _text;
        }
    }
}