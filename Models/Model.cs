
namespace Entity
{

    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public long RegistroUnico { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
            Nome = string.Empty;
            Endereco = string.Empty;
        }
    }

    

    public class Funcionario : Pessoa
    {

        public DateTime DataAdmissao { get; set; }

        public virtual void TempodeContribuicao()
        {
            DateTime dataAtual = DateTime.Now;
            TimeSpan result = dataAtual - DataAdmissao;

            int anos = dataAtual.Year - DataAdmissao.Year;
            int meses = dataAtual.Month - DataAdmissao.Month;
            int dias = dataAtual.Day - DataAdmissao.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);

            }
            else if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Tempo de contribuição de: {anos} anos, {meses} meses e {dias} dias."); // Exemplo que eu espero de saída: 2 anos, 3 meses e 5 dias.
        }
    }
}
