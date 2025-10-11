using Management.Interface;

namespace Management.Models.Repositories;

public class ProfessorRepository : IEnrollmentRepository<Teacher>
{
    private readonly List<Teacher> _professores = new()
    {
        new Teacher("301-A", new List<string>{"português", "Matemática"}, "PR0410", "Professor", 41, new (2020, 10, 5),  new (2019, 10, 05)),
        new Teacher("401-B", new List<string>{"Matemática"}, "PR0318", "Professor", 25, new (2020, 06, 03), new (2019, 06, 03))
        
    };
    
    public List<Teacher> GetAll() => _professores;

    public void Add(Teacher teacher)
    {
        _professores.Add(teacher);
    }
    
    public Teacher? GetByMatricula(string enrollment) 
        => _professores.FirstOrDefault(p => p.Enrollment == enrollment);
    
    
    
}