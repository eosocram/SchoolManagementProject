using Management.Models;
using System.Globalization;
using Management.Models.Repositories;
using Management.Services;

namespace Management;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("======PORTAL GESTEDUCA+======");
            Console.WriteLine("1 - COLABORADOR | 2 - PROFESSOR"); 
            int opcao = Convert.ToInt16(Console.ReadLine());

            string matricula = "";
            switch (opcao)
            {
                case 1:
                    
                    var repoProfessor = new ProfessorRepository();
                    var serviceProfessor = new ProfessorService(repoProfessor);
                    
                    Console.WriteLine("=====Acesso do PROFESSOR=====");
                    
                    serviceProfessor.LimiteHoraSemanal();
                    
                    // serviceProfessor.ExibirDadoProfessor();
                    // serviceProfessor.RegistrarAula();
                    // var p = repoProfessor.GetByMatricula(matricula);
                    // Console.WriteLine($"Carga horária depois: {p.CargaHorariaSemanal} horas");
                    // repoProfessor.GetAll().ForEach(p => Console.WriteLine(p.TurmasAssociadas));
                    break;
            }

        }
    }
