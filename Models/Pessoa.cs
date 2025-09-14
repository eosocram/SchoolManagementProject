namespace Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Cpf  { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Endereco { get; set; }
    }
}