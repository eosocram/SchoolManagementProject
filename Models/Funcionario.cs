namespace Models
{
    public class Funcionario : Pessoa
    {

        public DateTime DataAdmissao { get; set; }
        public long Matricula { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public double Salario { get; set; }

         public virtual void LoginFuncionario()
         {
            Console.Write("Digite o seu nome:");
            Nome = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome não pode ser nulo.");
            }
            if (Nome.Any(char.IsDigit))
            {
                throw new Exception("Nome não pode conter números.");
            }

            Console.Write($"{Nome} digite a sua Matrícula:");
            string? inputMatricula = Console.ReadLine()?.Trim();

            if  (!long.TryParse(inputMatricula, out long matricula) || inputMatricula.Length != 8)
            {
                Console.WriteLine($"Matrícula: {matricula}, inválida!");
            }
            else
            {
                Console.WriteLine($"Matrícula: {inputMatricula} - OK!");
            }
         }

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