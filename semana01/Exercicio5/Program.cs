using System;

class Program
{
    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira seu nome: ");
        return Console.ReadLine();
    }

    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira seu número favorito: ");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }

    static int ElevarAoQuadrado(int numero)
    {
        return numero * numero;
    }

    static void ExibirResultado(string nome, int numeroAoQuadrado)
    {
        Console.WriteLine($"{nome}, o quadrado do seu número é {numeroAoQuadrado}");
    }

    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nome = PerguntarNomeUsuario();
        int numeroFavorito = PerguntarNumeroFavorito();

        int quadrado = ElevarAoQuadrado(numeroFavorito);
        ExibirResultado(nome, quadrado);
    }
}