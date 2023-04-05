namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
               vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

            Salario salario = new Salario();

            salario.salarioBase = 1300;
            salario.totalVendas = 40;
            salario.comissao = 10;

            Console.WriteLine("O salério total do vendedor é de R$ {0:N2}", salario.CalcularSalarioTotal());
            Console.ReadLine();
        }
    }
}