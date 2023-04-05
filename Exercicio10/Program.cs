namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média ponderada de duas provas realizadas por um aluno
            Notas notas = new Notas();

            notas.nota1 = 10;
            notas.peso1 = 1;
            notas.nota2 = 8;
            notas.peso2 = 2;

            Console.WriteLine("A média ponderada do aluno é de {0:N2}.", notas.CalcularMedia());
            Console.ReadLine();
        }
    }
}