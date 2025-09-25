namespace Management.Models;

    public class Professor : Funcionario
    {
        public string TurmasAssociadas { get; set; }

        public List<string> Materia { get; set; }

        private double _cargaH; public double CargaHorariaSemanal
        {
            get => _cargaH;
            set => _cargaH = value;

        }

        public Professor(string turmaAssociada, List<string> materia, string matricula, string cargo, double cargaHoraria)
             : base(matricula, cargo)
        {
            TurmasAssociadas = turmaAssociada;
            Materia = materia;
            _cargaH = cargaHoraria;
        }

        public Professor(string matricula, string cargo) : base(matricula, cargo) { }
        
        public void RegistrarFrequencia(){}
        public void LancarNotas(){}
        
                
        
    }