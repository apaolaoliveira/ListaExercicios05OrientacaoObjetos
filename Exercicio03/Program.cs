namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de um cilindro
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 15;
            cilindro.raio = 5;

            Console.WriteLine("O volume desse cilindro é de {0:N0}.", cilindro.CalcularVolume());
            Console.ReadLine();
        }
    }
}