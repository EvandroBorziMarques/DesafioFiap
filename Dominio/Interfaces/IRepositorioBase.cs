using Dapper;

namespace Dominio.Interfaces
{
    public interface IRepositorioBase
    {        
        T QueryFirst<T>(string procedure, DynamicParameters parameters);
        List<T> Query<T>(string procedure, DynamicParameters parameters);
        bool Execute(string procedure, DynamicParameters parameters);
    }
}
