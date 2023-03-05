internal class Program
{
    private static void Main(string[] args)
    {
        int escolha, numero, res;

        Console.WriteLine("Escolha a tabuada de 1 a 9: ");
        escolha = int.Parse(Console.ReadLine());

        for(numero=0; numero<11; numero++)
        {
            res = escolha * numero;
            Console.WriteLine("\n {0} x {1} = {2}", escolha, numero, res);
        }
    }
}