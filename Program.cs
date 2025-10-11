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
            Console.WriteLine("1 - TEACHER | 2 - BUILDING"); 
            int opcao = Convert.ToInt16(Console.ReadLine());

            string matricula = "";
            switch (opcao)
            {
                case 1:
                    // var repoProfessor = new ProfessorRepository();
                    // Teacher teacher = repoProfessor.GetByMatricula("PR0410");
                    //
                    // if (teacher != null)
                    // {
                    //     Console.WriteLine(teacher.CalculateTeacherServiceTime());
                    // }
                    // else
                    // {
                    //     throw new ("Teacher not found!");
                    // }
                    //

                    Student testStudent = new Student();
                    testStudent.StatusStudent();
                    break;       
            }

        }
    }
