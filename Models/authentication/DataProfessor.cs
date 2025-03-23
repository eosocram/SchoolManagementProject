using Models;
namespace ModelsData
{
	public class Professor: Funcionario
	{
		static List<Professor> professoresMock = new List<Professor>
		{
				new Professor { Nome = "Marcos", Matricula = 1234, Senha = "1004"},
				new Professor { Nome = "Alice", Matricula = 5678, Senha = "0318"}
		};

		public static string ValidarLogin(long matricula, string senha)
		{


			var professor = professoresMock.FirstOrDefault(p => p.Matricula == matricula);
			if (professor == null)
			{
				throw new Exception("Professor não encontrado!");

			}
			if (professor.Senha != senha)
			{
				throw new Exception("Senha incorreta");
			}

			return $"Login efetuado com sucesso, Seja bem-vindo {professor.Nome}";


		}
	}
	
}
