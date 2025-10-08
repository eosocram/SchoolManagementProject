
using Management.Models.Repositories;

namespace Management.Models;

    public class Professor : Funcionario
    {
        public string TurmasAssociadas { get; set; }

        public List<string> Materia { get; set; }

        public double CargaHorariaSemanal { get; private set; }

        public Professor(string turmaAssociada, List<string> materia, string enrollment, string cargo, double cargaHoraria, DateTime admissionDate, DateTime lastDayDate)
             : base(enrollment, cargo, admissionDate)
        {
            
            TurmasAssociadas = turmaAssociada;
            Materia = materia;
            CargaHorariaSemanal = cargaHoraria;
            LastDay = lastDayDate;
        }
        
        public string CalculateTeacherServiceTime()
        {
            DateTime finalServiceTime = LastDay ?? DateTime.Now;

            if (LastDay.HasValue && AdmissionDate > LastDay.Value)
            {
                throw new ArgumentException("Admission date cannot be later than any termination date!");
            }
            if (LastDay.HasValue && AdmissionDate == LastDay.Value)
            {
                throw new ArgumentException("Termination date cannot be the same as admission date.");
            }
            
            int year = finalServiceTime.Year - AdmissionDate.Year;
            int month = finalServiceTime.Month - AdmissionDate.Month;
            int day = finalServiceTime.Day - AdmissionDate.Day;

            if (day < 0)
            {
                month--;
                var previousMonth = finalServiceTime.AddMonths(-1);
                day += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            if (month < 0)
            {
                year--;
                month += 12;
            }
            return $"The total working time was: {year} years, {month} months, {day} days.";
        }

        public void RegisterFrequency(){}
        public void LaunchNotes(){}


        public ProfessorRepository GetByMatricula(string enrollment)
        {
            throw new NotImplementedException();
        }
    }