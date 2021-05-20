using System;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Gharxp.Entities;
using Gharxp.Repository.Interface;
using static System.Data.CommandType;
using System.Linq;

using System.Data.Common;
using System.Threading.Tasks;

namespace Gharxp.Repository
{
    public class UserRepository : BaseRepo<User>, UserRepoInterface
    {
        private string ConnectionString;


        protected IDbConnection con;
        public UserRepository()
        {
            string connectionString = "Data Source=UJJWAL-PC;Initial Catalog=gharxp;Integrated Security=true";
            con = new SqlConnection(connectionString);
        }

        public bool Add(User user)
        {

            string sQuery = @"usp_tbl_User_Insert";
            con.Open();
            con.Execute(sQuery, user);
            return true;

            //DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@Name", user.Name);
            //parameters.Add("@AreaName", user.AreaName);
            //parameters.Add("@EmailId", user.EmailId);
            //parameters.Add("@ContactNo", user.ContactNo);
            //parameters.Add("@Pincode", user.Pincode);
            //parameters.Add("@City", user.City);
            //parameters.Add("@State", user.State);
            //SqlMapper.Execute(con, "Add", param, parameters , CommandType.StoredProcedure);
            //con.Execute(parameters, CommandType.StoredProcedure);
            //return true;

        }

        public bool Update(User user)
        {

            string sQuery = @"usp_tbl_User_Update";
            con.Open();
            con.Execute(sQuery, user);
            return true;

        }


        public async Task<IEnumerable<User>> GetAll()
        {

            //string sQuery = @"usp_tbl_User_SelectAll";
            //con.Open();
            //return SqlMapper.Query<User>(con,sQuery, commandType: CommandType.StoredProcedure);
            return await GetAll("usp_tbl_User_SelectAll", null);
        }
    }
}
//}
