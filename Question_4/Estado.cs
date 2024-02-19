public class Estado
{
    public string Nome { get; set; }
    public decimal Faturamento { get; set; }

    public Estado(string nome, decimal faturamento)
    {
        Nome = nome;
        Faturamento = faturamento;
    }
}
