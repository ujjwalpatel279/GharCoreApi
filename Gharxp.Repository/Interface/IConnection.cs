using System.Data;

namespace Gharxp.Repository.Interface
{
    public interface IConnection
    {
        IDbConnection GetConnection();
    }
}
