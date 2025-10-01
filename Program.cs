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
                    Professor professor = repoProfessor.GetByMatricula("PR0410");
                    if (professor != null)
                    {
                        Console.WriteLine(professor.TeacherServiceTime());
                    }
                    else
                    {
                        Console.WriteLine("Professor não encontrado!");
                    }
                    break;       
            }

        }
    }
