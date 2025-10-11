using System.ComponentModel.DataAnnotations;
using Management.Interface;
using Management.Models;

using Management.Models.Repositories;

namespace Management.Services;

public class ProfessorService : IEnrollmentRepository<
    Teacher>
{

    private readonly ProfessorRepository _repo;

    public ProfessorService(ProfessorRepository repo) 
    {
        _repo = repo;
    }


    public void TeacherTimeLimitExceeded()
    {
        //
        // /*
        //  * 1 -  Mudar retorno void;
        //  * 2- Tirar while;
        //  * 3- tirar excesso de writeLine
        //  * 4- receber tudo o que precisa por parametros
        //  * 5- implementar interface para repository e service.
        //  */
        //
        // var repoService = new ProfessorService(_repo);
        //
        // double horaTrabalhada = professor.CargaHorariaSemanal + 2;
        // if (horaTrabalhada > 40)
        // {
        //     throw new ArgumentException("Carga horária excedida, limite de 40H semanais atingida!");
        // }
        //
        // // while (professor == null)
        // //     Console.WriteLine("Digite o número de matrícula:");
        // //     string matricula = Console.ReadLine() ?? "";
        // //     professor = _repo.GetByMatricula(matricula);
        // //     if (professor == null)
        // //     {
        // //         Console.WriteLine("ERRO - Nenhum professor encontrado com essa matrícula! Tente novamente.");
        // //     }
        // // }
        // //
        // // double horaFutura = professor.CargaHorariaSemanal + 2;
        // // if (horaFutura > 40)
        // // {
        // //     Console.WriteLine($"{professor.Nome} Limite 40H excedido, volte por favor após uma semana a partir desta Data: {DateTime.Now}");
        // //     Console.WriteLine($"{professor.Materia[1]}");
        // //     return;
        // // }
        // //



    }

    public Teacher? GetByMatricula(string matricula)
    {
        throw new NotImplementedException();
    }
}