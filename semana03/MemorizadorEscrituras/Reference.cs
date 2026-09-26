using System;

class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _startVerse;
    private readonly int _endVerse;

    public Reference(string book, int chapter, int verse)
        : this(book, chapter, verse, verse)
    {
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        if (string.IsNullOrWhiteSpace(book))
        {
            throw new ArgumentException("O nome do livro não pode ficar vazio.", nameof(book));
        }

        if (chapter < 1 || startVerse < 1 || endVerse < startVerse)
        {
            throw new ArgumentOutOfRangeException(nameof(chapter), "Capítulo e versículos devem formar uma referência válida.");
        }

        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        string verseRange = _startVerse == _endVerse
            ? _startVerse.ToString()
            : $"{_startVerse}-{_endVerse}";

        return $"{_book} {_chapter}:{verseRange}";
    }
}