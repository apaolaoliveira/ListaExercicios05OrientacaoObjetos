namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de uma esfera
            Esfera esfera = new Esfera();

            esfera.raio = 10;

            Console.WriteLine("O volume dessa esfera é de {0:N0}.", esfera.CalcularVolume());
            Console.ReadLine();
        }
    }
}