using Management.Interface;

namespace Management.Models.Repositories;

public class ProfessorRepository : IEnrollmentRepository<Professor>
{
    private readonly List<Professor> _professores = new()
    {
        new Professor("301-A", new List<string>{"português", "Matemática"}, "PR0410", "Professor", 41, new (2020, 10, 5),  new (2025, 10, 05)),
        new Professor("401-B", new List<string>{"Matemática"}, "PR0318", "Professor", 25, new (2020, 06, 03), new (2019, 06, 03))
        
    };
    
    public List<Professor> GetAll() => _professores;

    public void Add(Professor professor)
    {
        _professores.Add(professor);
    }
    
    public Professor? GetByMatricula(string enrollment) 
        => _professores.FirstOrDefault(p => p.Enrollment == enrollment);
    
    
    
}