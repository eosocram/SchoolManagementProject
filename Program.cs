using Entity;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Digite o seu nome:");
            funcionario.Nome = Console.ReadLine() ?? "";

            Console.Write($"{funcionario.Nome} digite o seu CPF:");
            string inputCPF = Console.ReadLine() ?? "";
            if (long.TryParse(inputCPF, out long cpf))
            {
                funcionario.RegistroUnico = cpf;
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }

            Console.Write($"{funcionario.Nome} digite a data do seu nascimento:");
            string inputData = Console.ReadLine() ?? "";
            if (DateTime.TryParse(inputData, out DateTime dataNascimento))
            {
                funcionario.DataNascimento = dataNascimento;
                
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida.");
            }


            Console.Write($"{funcionario.Nome} digite o seu endereço:");
            funcionario.Endereco = Console.ReadLine() ?? "";

            Console.Write("Quando você entrou no seu emprego atual?");
            
            if (DateTime.TryParse(Console.ReadLine(), out DateTime anoAdmissao))
            {
                funcionario.DataAdmissao = anoAdmissao;
                Console.WriteLine($"Você entrou no emprego em: {funcionario.DataAdmissao.Year}");
                funcionario.TempodeContribuicao();
            }
            else
            {
                Console.WriteLine("Data inválida.");
            }
        }
    }
}