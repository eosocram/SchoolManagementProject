namespace Management.Interface;

public interface IRepositoryMatricula<T>
{
    T? GetByMatricula(string enrollment);
}