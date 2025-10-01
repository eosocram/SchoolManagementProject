
using Management.Models.Repositories;

namespace Management.Models;

    public class Professor : Funcionario
    {
        public string TurmasAssociadas { get; set; }

        public List<string> Materia { get; set; }

        public double CargaHorariaSemanal { get; private set; }

        public Professor(string turmaAssociada, List<string> materia, string matricula, string cargo, double cargaHoraria, DateTime admissionDate, DateTime? terminationDate)
             : base(matricula, cargo, admissionDate)
        {
            TurmasAssociadas = turmaAssociada;
            Materia = materia;
            CargaHorariaSemanal = cargaHoraria;
        }
        
        public string TeacherServiceTime()  
        
        {
            DateTime finalWork = TerminationDate ?? DateTime.Now;
            TimeSpan timeWork = finalWork - AdmissionDate;
            int years = (int)(timeWork.Days / 365.25);
            int months = (int)((timeWork.Days % 365.25) / 30);
            int days = (int)(timeWork.Days % 30);
            return $"O tempo total de trabalho foi: {years} anos, {months} meses, {days} dias.";
        }

        public void RegistrarFrequencia(){}
        public void LancarNotas(){}


        public ProfessorRepository? GetByMatricula(string matricula)
        {
            throw new NotImplementedException();
        }
    }