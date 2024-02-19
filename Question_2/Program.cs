using System;

class Programa
{
    static void Main()
    {
        Console.Write("Digite um número para verificar se este pertence a sequencia Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Fibonacci fibonacci = new Fibonacci();
        var sequenciaFibonacci = fibonacci.GerarFibonacci(numero);

        if (sequenciaFibonacci.Contains(numero))
        {
            Console.WriteLine("O número " + numero + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não pertence à sequência de Fibonacci.");
        }
    }
}