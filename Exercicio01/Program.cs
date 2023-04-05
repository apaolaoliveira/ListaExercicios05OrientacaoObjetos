namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            caixa.largura = 10;
            caixa.altura = 20;
            caixa.comprimento = 30;

            Console.WriteLine("O volume da caixa retangular é de " + caixa.CalcularVolume());
            Console.ReadLine();
        }
    }
}