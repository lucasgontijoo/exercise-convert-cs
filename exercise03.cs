class CatingExemplo
{
    public int Dividir(int a, float b)
    {
        float resultado = a/b;
        int resultadoConvertido = (int)resultado;

        return resultadoConvertido;
    }

    public void Transformar(object obj)
    {
        string convercao = (string)obj;

        if(convercao)
        {
            Console.WriteLine("Conversão não foi realizada.");
        }
    }
}