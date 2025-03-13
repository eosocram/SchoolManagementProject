using Models;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------PORTAL COLÉGIO FUTURO MELHOR----------");
            Console.WriteLine("Escolha a opção desejada: 1 - ESPAÇO DO COLABORADOR");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {

                case 1:
                    Console.WriteLine("-----------ESPAÇO DO COLABORADOR-----------");

                    Funcionario funcionario = new Funcionario();

                    try
                    {
                        Console.Write("Digite o seu nome:");
                        funcionario.Nome = Console.ReadLine()?.Trim();

                        if (string.IsNullOrEmpty(funcionario.Nome))
                        {
                            throw new Exception("Nome não pode ser nulo.");
                        }
                        if (funcionario.Nome.Any(char.IsDigit))
                        {
                            throw new Exception("Nome não pode conter números.");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"ERROR: {ex.Message}");
                        return;
                    }

                    try
                    {
                        Console.Write($"{funcionario.Nome} digite o seu CPF:");
                        string inputCpf = Console.ReadLine()?.Trim();

                        if (!long.TryParse(inputCpf, out long cpf) || inputCpf.Length != 11)
                        {
                            throw new Exception("CPF inválido. Deve conter 11 números");
                        }
                        funcionario.RegistroUnico = long.Parse(inputCpf);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ERROR: {ex.Message}");
                        return;
                    }
                    break;
                
            }
        }
    }
}