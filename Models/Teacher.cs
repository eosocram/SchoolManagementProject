
using Management.Models.Repositories;

namespace Management.Models;

    public class Teacher : Employee
    {
        public string AssociatedClass { get; set; }

        public List<string> Matter { get; set; }

        public double WeeklyWorkLoad { get; private set; }

        public Teacher(string associatedClass, List<string> matter, string enrollment, string responsability, double weeklyWorkLoad, DateTime admissionDate, DateTime lastDayDate)
             : base(enrollment, responsability, admissionDate)
        {
            
            AssociatedClass = associatedClass;
            Matter = matter;
            WeeklyWorkLoad = weeklyWorkLoad;
            LastDay = lastDayDate;
        }


        public void RegisterFrequency(){}
        public void LaunchNotes(){}


        public ProfessorRepository GetByMatricula(string enrollment)
        {
            throw new NotImplementedException();
        }
    }