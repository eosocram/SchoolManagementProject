namespace Management.Models;

    public abstract class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Cpf  { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;
    }
