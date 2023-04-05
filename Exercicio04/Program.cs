namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
             Inicial e Final do Percurso do Veículo, além do Consumo de Combustível */
            Combustivel combustivel = new Combustivel();

            combustivel.kmInicial = 30;
            combustivel.kmFinal = 400;
            combustivel.consumoCombustivel = 120;

            Console.WriteLine("O consumo de combustivel por Km foi de " + combustivel.CalcularConsumo() + " por km."); 
            Console.ReadLine();
        }
    }
}