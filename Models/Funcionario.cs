namespace Models
{
    public class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public DateTime DataRecisao { get; set; }

        public Funcionario(int matricula, DateTime dataAdmissao, DateTime dataRecisao)
        {
            Matricula = matricula;
            // Cargo = cargo;
            // Salario = salario;
            DataAdmissao = dataAdmissao;
            DataRecisao = dataRecisao;
        }

        public void TempoDeServico()
        {
            int anos = DataRecisao.Year - DataAdmissao.Year;
            int meses = DataRecisao.Month - DataAdmissao.Month;

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"O tempo de serviço é do colaborador: {this.Nome} é de {anos} anos e {meses} meses");
        }


    }
}