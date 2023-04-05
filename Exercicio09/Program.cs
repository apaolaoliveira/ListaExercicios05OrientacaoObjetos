namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média harmônica das notas de um Aluno
            Notas notas = new Notas();

            notas.nota1 = 10;
            notas.nota2 = 5;
            notas.peso1 = 5;
            notas.peso2 = 3;

            Console.WriteLine("A média harmonica das notas é {0:N2}.", notas.CalcularMediaHarmonica());
            Console.ReadLine();
        }
    }
}