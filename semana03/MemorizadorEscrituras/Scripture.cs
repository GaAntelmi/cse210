using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference ?? throw new ArgumentNullException(nameof(reference));
        if (text == null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int index = 0; index < wordsToHide; index++)
        {
            int randomIndex = Random.Shared.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayedWords = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference} {displayedWords}";
    }
}