public class InversorDeTexto
{
    public string InverterString(string texto)
    {
        char[] caracteres = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[texto.Length - i - 1];
        }

        return new string(caracteres);
    }
}
