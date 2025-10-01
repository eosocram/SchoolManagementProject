namespace Management.Models;

    public class Funcionario : Pessoa
    {
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? TerminationDate { get; set; }

        public Funcionario(string matricula, string cargo, DateTime admissionDate)
        {
            Matricula = matricula;
            Cargo = cargo;
            
            if (AdmissionDate > DateTime.Now)
            {
                throw new ArgumentException("Data de admissão não pode estar no futuro!");
            }
            AdmissionDate = admissionDate;
        }

        
    }
