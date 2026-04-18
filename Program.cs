using System.Drawing;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("""
            =======================================================
                    SISTEMA DE EXERCÍCIOS - OOP & TIPOS
            =======================================================
            1 - Exercício 1: Sobrecarga de Métodos (Operações)
            2 - Exercício 2: Coerção Implícita (Conversor de Valores)
            3 - Exercício 3: Coerção Explícita (Casting e Objetos)
            4 - Exercício 4: Polimorfismo (Formas Geométricas)
            0 - Sair do Programa
            -------------------------------------------------------
            Escolha uma opção:

            """
        );
        string opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
                Operacoes op = new Operacoes();

                Console.WriteLine(op.Calcular(1, 2));
                Console.WriteLine(op.Calcular(100, 50, 25));
                Console.WriteLine(op.Calcular(2.5, 2.5));

                break;

            case "2":

                ConversorValores conv = new ConversorValores();
                Console.WriteLine(conv.Somar(1, 1.3333f));
                conv.Exibir(90);

                break;

            case "3":

                CastingExemplo cast = new CastingExemplo();
                Console.WriteLine(cast.Dividir(20, 5.2f));

                Retangulo r = new Retangulo(1, 2);
                Console.WriteLine(cast.Transformar(r));

                break;

            case "4":

                Retangulo rr = new Retangulo(1, 2);
                Circulo c = new Circulo(100);

                rr.CalcularArea();
                c.CalcularArea();

                break;

            case "0":
                Console.WriteLine("Saindo...");
                break;

            default:
                Console.WriteLine("Escolha uma dentre as opções acima.");
                break;
        }
    }
}