using Models;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------PORTAL COLÉGIO FUTURO MELHOR----------");
                Console.WriteLine("Acesse: 1 - ESPAÇO DO COLABORADOR");
                string? inputMenu = Console.ReadLine()?.Trim();
                if (int.TryParse(inputMenu, out int menu))
                {
                    Console.WriteLine($"{menu} - BEM VINDO AO ESPAÇO DO COLABORADOR.");
                }
                else
                {
                    Console.WriteLine("Número ou carácter não permitido!");
                }

                switch (menu)
                {

                    case 1:
                        Funcionario funcionario = new Funcionario();
                        funcionario.LoginFuncionario();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
