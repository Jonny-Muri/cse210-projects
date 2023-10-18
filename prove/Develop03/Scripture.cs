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
        numberToHide = r.Next(1,3);

    }

    public string GetDisplayText()
    {
        string combined = string.Join(" ", _words);
        return String.Format("{0} {1}", _reference.GetDisplayText(), combined);
    }

    //This needs to be a bool
    public bool IsCompletelyHidden()
    {
        return true;
    }
}