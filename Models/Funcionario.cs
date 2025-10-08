namespace Management.Models;

    public class Funcionario : Pessoa
    {
        public string Enrollment { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? LastDay{ get; set; }

        public Funcionario(string enrollment, string cargo, DateTime admissionDate)
        {
            Enrollment = enrollment;
            Cargo = cargo;
            
            if (AdmissionDate > DateTime.Now)
            {
                throw new ArgumentException("Não existe registro de admissão no futuro!");
            }
            AdmissionDate = admissionDate;
        }

        
    }
