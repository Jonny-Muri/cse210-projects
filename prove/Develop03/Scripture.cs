using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Scripture
{
    Reference _reference;
    public List<Word> _words;
    Random r = new Random();

    public Scripture(Reference reference, string text) 
    {
        // Set the global reference member variable to the local parameter
        // to save it for later.
        _reference = reference;
        // Create a new list of Word objects
        _words = new List<Word>();
        // First, separate the scripture into its individual words
        string[] words = text.Split(' ');
        // then, create a Word object for each word in the list
        foreach (string word in words) {
            Word newWord = new Word(word);
            // and append it to the list of Word objects.
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int valueToHide = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden() == false && numberToHide > valueToHide)
            {
                valueToHide ++;
            }
        }

        Random random = new Random();
        // loop numberToHide times
        for (int i = 0; i < valueToHide; i++)
        {
        // generate a random number between 0 - _words.length
            int j = random.Next(0, _words.Count());

        // if _words[i].getIsHidden() is already true, get a different random number
            while (_words[j].IsHidden() == true)
            {
                j = random.Next(0, _words.Count());
            }
        // if _words[i].getIsHidden() is false, than change _isHidden to True
            if(_words[j].IsHidden() == false)
            {
                _words[j].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string combined = "";
        foreach (Word ctext in _words)
        {
            combined += " " + ctext.GetDisplayText();
        }
        return String.Format("{0} {1}", _reference.GetDisplayText(), combined);
    }

    //This needs to be a bool
    public bool IsCompletelyHidden()
    {
        return true;
    }
}