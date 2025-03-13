namespace Models
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
}
