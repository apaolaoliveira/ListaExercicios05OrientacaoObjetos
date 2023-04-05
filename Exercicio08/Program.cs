namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma lata de óleo

            Oleo oleo = new Oleo();

            oleo.altura = 10;
            oleo.raio = 2;

            Console.WriteLine("O volume da lata é {0:N0}.", oleo.CalcularVolume());
            Console.ReadLine();
        }
    }
}