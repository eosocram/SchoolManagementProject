namespace Management.Interface;

public interface IEnrollmentRepository<TEntity>
{
    TEntity? GetByMatricula(string enrollment);
}