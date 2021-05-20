using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Gharxp.Repository.Interface;

namespace Gharxp.Repository
{
    public class BaseRepo<T> : IRepo<T>
    {
        private string ConnectionString;


        protected IDbConnection con;
        public BaseRepo()
        {
            string connectionString = "Data Source=UJJWAL-PC;Initial Catalog=gharxp;Integrated Security=true";
            con = new SqlConnection(connectionString);
        }


        public async Task<List<T>> GetAll(string procedure, object parameters = null)
        {
            //IDbConnection connection = _connectionFactory.GetConnection();
            return (await con.QueryAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure)).ToList();
        }

        public async Task<T> Get(string procedure, object parameters = null)
        {
            //IDbConnection connection = _connectionFactory.GetConnection();
            return await con.QuerySingleOrDefaultAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<T>> Find(string procedure, object parameters = null)
        {
            //IDbConnection connection = _connectionFactory.GetConnection();
            return (await con.QueryAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure)).ToList();
        }

        public async Task<T> Save(string procedure, T parameters)
        {
            //IDbConnection connection = _connectionFactory.GetConnection();
            return await con.QuerySingleOrDefaultAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<object> Save(string procedure, object parameters)
        {
            //IDbConnection connection = _connectionFactory.GetConnection();
            return await con.QuerySingleOrDefaultAsync<T>(procedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
