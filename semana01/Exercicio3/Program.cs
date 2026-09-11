using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            Random geradorAleatorio = new Random();
            int numeroMagico = geradorAleatorio.Next(1, 101);
            int palpite = 0;
            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (palpite != numeroMagico)
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("O número mágico é maior.");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("O número mágico é menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativa(s)!");
                }
            }

            Console.Write("Deseja jogar novamente? (sim/nao): ");
            jogarNovamente = Console.ReadLine().ToLower();
        }
    }
}