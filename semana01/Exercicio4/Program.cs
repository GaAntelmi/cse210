using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        List<int> numeros = new List<int>();

        while (true)
        {
            Console.Write("Insira o número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break;
            }

            numeros.Add(numero);
        }

        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        double media = 0;
        if (numeros.Count > 0)
        {
            media = (double)soma / numeros.Count;
        }

        int maior = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        List<int> positivos = new List<int>();
        foreach (int numero in numeros)
        {
            if (numero > 0)
            {
                positivos.Add(numero);
            }
        }

        int menorPositivo = 0;
        if (positivos.Count > 0)
        {
            menorPositivo = positivos.Min();
        }

        List<int> numerosOrdenados = new List<int>(numeros);
        numerosOrdenados.Sort();

        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maior}");

        if (positivos.Count > 0)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        Console.WriteLine("A lista reordenada é:");
        foreach (int numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }
}