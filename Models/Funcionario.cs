namespace Management.Models;

    public class Funcionario : Pessoa
    {
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataRecisao { get; set; }

        public Funcionario(string matricula, string cargo)
        {
            Matricula = matricula;
            Cargo = cargo;

        }

        public void TempoDeServico()
        {
            if (DataRecisao.HasValue)
            {
                int anos = DataRecisao.Value.Year - DataAdmissao.Year;
                int meses = DataRecisao.Value.Year - DataAdmissao.Month;
                
                
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                    Console.WriteLine($"O tempo de serviço é do colaborador: {Nome} é de {anos} anos e {meses} meses");
                }
            }
            else
            {
                Console.WriteLine("O colaborador ainda está ativo.");
            }
        }


    }
