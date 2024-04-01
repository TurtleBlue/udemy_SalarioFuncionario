namespace udemy_SalarioFuncionario
{
    /* Fazer um programa para ler os dados de um funcionário (nome, salario bruto e imposto). 
     * Em seguida, mostrar os dados do funcionário (nome e salário líquido).
     * Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada
     * (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite as informações do funcionario: \n");

            Console.WriteLine("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Salario bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {funcionario.nome}\n" +
                $"Salário: {funcionario.SalarioLiquido():n2}\n");

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Qual a porcentagem que deseja aumentar o salário?");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Os novos valores são: \n" +
                $"Funcionario: {funcionario.nome}\n" +
                $"Salario: {funcionario.SalarioLiquido():n2}");
        }
    }
}