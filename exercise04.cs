public abstract class Forma
{
    public virtual void CalcularArea()
    {

    }
}

class Retangulo : Forma
{
    public int Altura { get; set; }
    public int Largura { get; set; }

    public Retangulo(int altura, int largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public override void CalcularArea()
    {
        int area = Altura * Largura;
    }
}

class Circulo : Forma
{
    public int Raio { get; set; }

    public Circulo(int raio)
    {
        Raio = raio;
    }
    public override void CalcularArea()
    {
        double area = Math.Pow(Raio, 2) * Math.PI;
    }
}