using System;

class Program
{
    static void Main()
    {
        var distribuidora = new Distribuidora();

        distribuidora.Estados.Add(new Estado("SP", 67836.43m));
        distribuidora.Estados.Add(new Estado("RJ", 36678.66m));
        distribuidora.Estados.Add(new Estado("MG", 29229.88m));
        distribuidora.Estados.Add(new Estado("ES", 27165.48m));
        distribuidora.Estados.Add(new Estado("Outros", 19849.53m));

        foreach (var estado in distribuidora.Estados)
        {
            var percentual = distribuidora.PercentualRepresentacao(estado);
            Console.WriteLine($"Estado: {estado.Nome}, Faturamento: {estado.Faturamento:C}, Representação: {percentual:F2}%");
        }
    }
}