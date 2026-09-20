using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // Campo extra para exceder os requisitos

    public void Display()
    {
        Console.WriteLine($"Data: {_date} - Pergunta: {_promptText}");
        Console.WriteLine($"Humor do dia: {_mood}");
        Console.WriteLine($"Resposta: {_entryText}\n");
    }
}