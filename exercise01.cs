class Operacoes
{
    public int Calcular(int a, int b)
    {
        return a + b;
    }

    public int Calcular(int a, int b, int c)
    {
        int maior = a;

        if (b > a)
        {
            maior = b;
        }
        else if (c > a)
        {
            maior = c;
        }

        return maior;
    }

    public double Calcular(double a, double b)
    {
        return a * b;
    }
}