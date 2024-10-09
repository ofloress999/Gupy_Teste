using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma atividade:");
        Console.WriteLine("1 - Verificar se um número pertence à sequência de Fibonacci");
        Console.WriteLine("2 - Contar a quantidade de letras 'A' em uma palavra");
        Console.WriteLine("3 - Calcular a soma dos números de 1 até um número");
        Console.WriteLine("4 - Completar a lógica de sequências");
        Console.WriteLine("5 - Descobrir qual interruptor controla qual lâmpada");
        Console.Write("Digite o número da atividade desejada: ");
        
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                AtividadeFibonacci();
                break;
            case 2:
                AtividadeContarA();
                break;
            case 3:
                AtividadeSoma();
                break;
            case 4:
                AtividadeSequencias();
                break;
            case 5:
                AtividadeInterruptores();
                break;
            default:
                Console.WriteLine("Atividade inválida. Por favor, escolha um número de 1 a 5.");
                break;
        }
    }

    static void AtividadeFibonacci()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        while (a <= num)
        {
            if (a == num)
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
                return;
            }
            int proximo = a + b;
            a = b;
            b = proximo;
        }
        Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
    }

    static void AtividadeContarA()
    {
        int num = 0;
        string text;

        Console.Write("Escreva uma palavra: ");
        text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            char caracter = text[i];
            if (caracter == 'a' || caracter == 'A')
            {
                num++;
            }
        }

        if (num >= 1)
        {
            Console.WriteLine($"A palavra {text} possui a letra A.");
        }
        else
        {
            Console.WriteLine($"A palavra {text} não possui a letra A.");
        }
        Console.WriteLine($"Quantidade de 'a' ou 'A' encontrado(s): {num}");
    }

    static void AtividadeSoma()
    {
        int indice = 12, soma = 0, k = 1;

        while (k < indice)
        {
            k++;
            soma = soma + k;
        }

        Console.WriteLine($"A soma dos números de 1 até {indice} é: {soma}");
    }

    static void AtividadeSequencias()
    {
        Console.WriteLine($"a) 1, 3, 5, 7, {7 + 2}");
        Console.WriteLine($"b) 2, 4, 8, 16, 32, 64, {64 * 2}");
        Console.WriteLine($"c) 0, 1, 4, 9, 16, 25, 36, {7 * 7}");
        Console.WriteLine($"d) 4, 16, 36, 64, {10 * 10}");
        Console.WriteLine($"e) 1, 1, 2, 3, 5, 8, {5 + 8}");
        Console.WriteLine($"f) 2, 10, 12, 16, 17, 18, 19, {20}");
    }

    static void AtividadeInterruptores()
    {
        bool[] interruptores = new bool[3];
        bool[] lampadas = new bool[3];

        lampadas[1] = true; // Liga a lâmpada 2

        Console.WriteLine("Ligando o primeiro interruptor (A)...");
        interruptores[0] = true; // Lâmpada A fica ligada

        Console.WriteLine("Desligando o primeiro interruptor (A) e ligando o segundo (B)...");
        interruptores[0] = false; // Desliga A
        interruptores[1] = true; // Liga B

        Console.WriteLine("Verificando as lâmpadas...");

        for (int i = 0; i < lampadas.Length; i++)
        {
            string estado = lampadas[i] ? "ligada" : "desligada";
            Console.WriteLine($"Lâmpada {i + 1} está {estado}.");
        }

        Console.WriteLine("\nConclusão:");
        Console.WriteLine("A lâmpada 2 é controlada pelo interruptor B (ligada).");
        Console.WriteLine("A lâmpada 1 é controlada pelo interruptor A (desligada).");
        Console.WriteLine("A lâmpada 3 é controlada pelo interruptor C (desligada).");
    }
}
