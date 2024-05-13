using Dapper;

namespace Dominio.Interfaces
{
    public interface IRepositorioBase
    {        
        T QuereyFirst<T>(string procedure, DynamicParameters parameters);
        List<T> Query<T>(string procedure, DynamicParameters parameters);
        bool Execute(string procedure, DynamicParameters parameters);
    }
}
