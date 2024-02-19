
using System.Collections.Generic;
using System.Linq;

public class Distribuidora
{
    public List<Estado> Estados { get; set; }

    public Distribuidora()
    {
        Estados = new List<Estado>();
    }

    public decimal FaturamentoTotal()
    {
        return Estados.Sum(e => e.Faturamento);
    }

    public decimal PercentualRepresentacao(Estado estado)
    {
        return (estado.Faturamento / FaturamentoTotal()) * 100;
    }
}
