using Management.Interface;

namespace Management.Models.Repositories;

public class ProfessorRepository : IRepositoryMatricula<Professor>
{
    private readonly List<Professor> _professores = new()
    {
        new Professor("301-A", new List<string>{"português", "Matemática"}, "PR0410", "Professor", 41, new DateTime(2020, 10, 10), new DateTime(2025, 03, 10)),
        new Professor("401-B", new List<string>{"Matemática"}, "PR0318", "Professor", 25, new DateTime(2025, 06, 03), new DateTime(DateTime.Now.Ticks))
        
    };
    
    public List<Professor> GetAll() => _professores;

    public void Add(Professor professor)
    {
        _professores.Add(professor);
    }
    
    public Professor? GetByMatricula(string matricula) 
        => _professores.FirstOrDefault(p => p.Matricula == matricula);
    
    
    
}