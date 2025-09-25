using Management.Interface;

namespace Management.Models.Repositories;

public class ProfessorRepository : IRepositoryMatricula<Professor>
{
    private readonly List<Professor> _professores = new()
    {
        new Professor( "301-A", new List<string>{"português", "Matemática"}, "PR0410", "Professor", 41),
        new Professor("401-B", new List<string>{"Matemática"}, "PR0318", "Professor", 25)
        
    };
    
    public List<Professor> GetAll() => _professores;

    public void Add(Professor professor)
    {
        _professores.Add(professor);
    }
    
    public Professor? GetByMatricula(string matricula) 
        => _professores.FirstOrDefault(p => p.Matricula == matricula);
    
    
    
}