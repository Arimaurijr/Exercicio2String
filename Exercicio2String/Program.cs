internal class Program
{
    private static void Main(string[] args)
    {
        string palavra1, palavra2;

        Console.Write("DIGITE A PRIMEIRA PALVRA: ");
        palavra1 = Console.ReadLine();
        Console.WriteLine();

        Console.Write("DIGITE A SEGUNDA PALAVRA: ");
        palavra2 = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("CONSIDERANDO DIFERENÇA ENTRE MINÚSCULA E MAIÚSCULA");
        if (palavra1.Equals(palavra2))
        {
            Console.WriteLine("AS DUAS PALVRAS SÃO IGUAIS !!!");
        }
        else
        {
            Console.WriteLine("AS DUAS PALAVRAS NÃO SÃO IGUAIS !!!");
        }

        Console.WriteLine("DESCONSIDERANDO A DIFERENÇA ENTRE MINÚSCULA E MAIÚSCULA");
        if (palavra1.ToLower().Equals(palavra2.ToLower()))
        {
            Console.WriteLine("AS DUAS PALAVRAS SÃO IGUAIS !!!");
        }
        else
        {
            Console.WriteLine("AS DUAS PALAVRAS NÃO SÃO IGUAIS !!!");
        }
    }
}