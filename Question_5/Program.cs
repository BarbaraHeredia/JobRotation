using System;

class Programa
{
    static void Main()
    {
        var inversor = new InversorDeTexto();

        Console.Write("Digite uma frase ou texto para ver como esta se escreve ao contrario: ");
        string textoOriginal = Console.ReadLine();

        string textoInvertido = inversor.InverterString(textoOriginal);

        Console.WriteLine($"Texto original: {textoOriginal}");
        Console.WriteLine($"Texto invertido: {textoInvertido}");
    }
}