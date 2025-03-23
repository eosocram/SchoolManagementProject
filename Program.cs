using Models;
using ModelsData;
namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------PORTAL COLÉGIO FUTURO MELHOR----------");
                Console.WriteLine("Acesse: 1 - ESPAÇO DO COLABORADOR | 2 - ÁREA DO ESTUDANTE");
                string? inputMenu = Console.ReadLine()?.Trim();

                if (!int.TryParse(inputMenu, out int menu))
                {
                    Console.WriteLine("Loading...");
                    return;
                }

                switch (menu)
                {

                    case 1:
                        Console.WriteLine("----------ESPAÇO DO COLABORADOR----------");
                        Console.WriteLine("Acesse: 1 - PROFESSOR | 2 - FUNCIONÁRIO");
                        string? inputColaborador = Console.ReadLine()?.Trim();
                        if (!int.TryParse(inputColaborador, out int opcaoColaborador))
                        {
                            Console.WriteLine("Digite um número válido.");
                            return;
                        }
                            switch (opcaoColaborador)
                            {
                                case 1:
                                    LoginProfessor();
                                    break;
                                case 2:
                                    Console.WriteLine("Login de funcionário ainda não implementado.");
                                break;
                                default:
                                Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
                                break;
                            }





                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        static private void LoginProfessor()
        {

            ModelProfessor professor = new ModelProfessor();
            Console.Write($"Digite a sua Matrícula:");
            string? inputMatricula = Console.ReadLine()?.Trim();

            if (!long.TryParse(inputMatricula, out long matricula) || inputMatricula.Length != 4)
            {
                Console.WriteLine($"ERRO: Sua matrícula deve conter apenas 4 dígitos!");
                return;
            }
            else
            {
               
                Console.WriteLine($"Matrícula: {inputMatricula} - OK!");
            }

            Console.Write($"Digite a sua senha:");
            string senha = Console.ReadLine()?.Trim() ?? string.Empty;
            
            string validacaoProfessor = ModelsData.Professor.ValidarLogin(matricula, senha);
            Console.WriteLine(validacaoProfessor);


            Console.WriteLine($"Matrícula inserida: {matricula}");
            Console.WriteLine($"Senha inserida: {senha}");


        }
      
    }
}
    