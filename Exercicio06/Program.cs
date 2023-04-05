namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converter a temperatura da escala Celsius para a escala Fahrenheit
            Temperatura temperatura = new Temperatura();

            temperatura.celsius = 13;

            Console.WriteLine("A conversão de Fahrenheit para Celsius é " + temperatura.CalcularConversao() + "ºC.");
            Console.ReadLine();
        }
    }
}