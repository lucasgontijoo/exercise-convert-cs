class CatingExemplo
{
    public int Dividir(int a, float b)
    {
        float resultado = a/b;
        int resultadoConvertido = (int)resultado;

        return resultadoConvertido;
    }

    public string Transformar(object obj)
    {
        string conversao = (string)obj;

        if(conversao is string)
        {
            return conversao;
        } else
        {
            Console.WriteLine("Conversão não realizada!");
            return null;
        }
    }
}