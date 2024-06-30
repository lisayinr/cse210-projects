using System;
class Scripture
{
    private List<Word> _words = new ();
    private Reference _reference;
    private Random _rng = new ();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] wordAry = text.Split();
        foreach (string wordStr in wordAry)
        {
            Word wordObj = new Word(wordStr);
            _words.Add(wordObj);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        int index;
        for(int i = 0; i < numberToHide; i ++ )
        {
            do
            {
                index = _rng.Next(_words.Count);

            } while (_words[index].IsHidden());
            _words[index].Hide();
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
        string displaytext = "";
        displaytext += _reference.GetDisplayText() + " - ";
        foreach (Word word in _words)
        {
            displaytext += word.GetDisplayText() + " ";
        }
        return displaytext;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}