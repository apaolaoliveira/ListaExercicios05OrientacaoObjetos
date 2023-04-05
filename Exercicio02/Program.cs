namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converter a temperatura de graus Fahrenheit para graus Celsius

            Temperatura temperatura = new Temperatura();

            temperatura.fahrenheit = 70;

            Console.WriteLine("A conversão de Fahrenheit para Celsius é " + temperatura.ConverterTemperatura() + "ºC.");
            Console.ReadLine();
        }
    }
}