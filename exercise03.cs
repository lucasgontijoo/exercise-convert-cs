class CastingExemplo
{
    public int Dividir(int a, float b)
    {
        float resultado = a / b;
        int resultadoConvertido = (int)resultado;

        return resultadoConvertido;
    }

    public string Transformar(object obj)
    {

        try
        {
            string conversao = (string)obj;
            return conversao;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Conversão não realizada!");
            return null!;
        }
    }
}