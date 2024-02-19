using Newtonsoft.Json;
using question_3;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Programa
{
    static void Main()
    {
        string caminhoDoArquivo = "dados.json";

        var faturamentoDiario = JsonConvert.DeserializeObject<List<Faturamento>>(File.ReadAllText(caminhoDoArquivo));

        // Remover os dias sem faturamento (representados por 0.0)
        var faturamentoDiarioSemNulos = faturamentoDiario.Where(f => f.valor > 0).ToList();

        // Calcular o menor e o maior valor de faturamento
        var menorFaturamento = faturamentoDiarioSemNulos.Min(f => f.valor);
        var maiorFaturamento = faturamentoDiarioSemNulos.Max(f => f.valor);

        // Calcular a média mensal de faturamento
        var mediaFaturamento = faturamentoDiarioSemNulos.Average(f => f.valor);

        // Calcular o número de dias em que o faturamento foi superior à média
        var diasAcimaDaMedia = faturamentoDiarioSemNulos.Count(f => f.valor > mediaFaturamento);

        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}