using System;

class Program
{
    static void Main(string[] args)
    {
        // Além do básico: uma biblioteca de escrituras é escolhida aleatoriamente a cada execução.
        Scripture[] library =
        {
            new Scripture(
                new Reference("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."),
            new Scripture(
                new Reference("Salmos", 23, 1),
                "O Senhor é o meu pastor, nada me faltará."),
            new Scripture(
                new Reference("Filipenses", 4, 13),
                "Posso todas as coisas naquele que me fortalece.")
        };

        Scripture scripture = library[Random.Shared.Next(library.Length)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Pressione Enter para ocultar palavras ou digite 'sair' para encerrar: ");

            string input = Console.ReadLine();
            if (input == null || input.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}