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
                

                break;

            case "2":
                break;

            case "3":
                break;

            case "4":
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