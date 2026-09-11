using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua nota numérica: ");
        int nota = int.Parse(Console.ReadLine());

        string letra = "";
        string sinal = "";

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        if (letra == "A" || letra == "F")
        {
            sinal = "";
        }
        else
        {
            int ultimoDigito = nota % 10;

            if (ultimoDigito >= 7)
            {
                sinal = "+";
            }
            else if (ultimoDigito < 3)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
        }

        Console.WriteLine($"Sua nota conceitual é: {letra}{sinal}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado.");
        }
        else
        {
            Console.WriteLine("Você não foi aprovado. Continue tentando!");
        }
    }
}