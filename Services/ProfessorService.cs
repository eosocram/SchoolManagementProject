using System.ComponentModel.DataAnnotations;
using Management.Models;

using Management.Models.Repositories;

namespace Management.Services;

public class ProfessorService
{

    private readonly ProfessorRepository _repo;

    public ProfessorService(ProfessorRepository repo) 
    {
        _repo = repo;
    }


    public void LimiteHoraSemanalProfessor()
    {
        
        /*
         * 1 -  Mudar retorno void;
         * 2- Tirar while;
         * 3- tirar excesso de writeLine
         * 4- receber tudo o que precisa por parametros
         * 5- implementar interface para repository e service.
         */
        // Professor? professor = _repo.GetByMatricula(matriculaProfessor); 
        // while (professor == null)
        //     Console.WriteLine("Digite o número de matrícula:");
        //     string matricula = Console.ReadLine() ?? "";
        //     professor = _repo.GetByMatricula(matricula);
        //     if (professor == null)
        //     {
        //         Console.WriteLine("ERRO - Nenhum professor encontrado com essa matrícula! Tente novamente.");
        //     }
        // }
        //
        // double horaFutura = professor.CargaHorariaSemanal + 2;
        // if (horaFutura > 40)
        // {
        //     Console.WriteLine($"{professor.Nome} Limite 40H excedido, volte por favor após uma semana a partir desta Data: {DateTime.Now}");
        //     Console.WriteLine($"{professor.Materia[1]}");
        //     return;
        // }
        //
        


    }
    
}