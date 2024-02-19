using System.Collections.Generic;

class Fibonacci
{
    public List<int> GerarFibonacci(int numero)
    {
        List<int> sequencia = new List<int> { 0, 1 };

        while (sequencia[sequencia.Count - 1] < numero)
        {
            int proximoNumero = sequencia[sequencia.Count - 1] + sequencia[sequencia.Count - 2];
            sequencia.Add(proximoNumero);
        }

        return sequencia;
    }
}