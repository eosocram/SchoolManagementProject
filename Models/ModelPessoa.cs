namespace Models
{

    public abstract class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public long RegistroUnico { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;

       
    }
}
