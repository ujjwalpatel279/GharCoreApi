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

namespace Gharxp.Repository
{
    public class UserRepository : UserRepoInterface
    {
        private string ConnectionString;

        //public UserRepository()
        //{
        //    ConnectionString = @"Data Source=UJJWAL-PC;Initial Catalog=gharxp;Integrated Security=true";
        //}

        //public IDbConnection Connection
        //{
        //    get
        //    {
        //        return new SqlConnection();
        //    }
        //}

        protected IDbConnection con;
        public UserRepository()
        {
            string connectionString = "Data Source=UJJWAL-PC;Initial Catalog=gharxp;Integrated Security=true";
            con = new SqlConnection(connectionString);
        }

        public bool Add(User Usr)
        {
            //using (IDbConnection dbConnection = Connection)
            //{
            //    string Query = @"insert into User(Name,AreaName,EmailId,ContactNo,Pincode,City,State) Values(@Name,@AreaName,@EmailId,@ContactNo,@Pincode,@City,@State)";
            //    dbConnection.Open();
            //    dbConnection.Execute(Query, Usr);
            //    return true;

            //}
            return true;

        }

        public IEnumerable<User> GetAll()
        {
          
            string sQuery = @"usp_tbl_User_SelectAll";
            con.Open();
            return SqlMapper.Query<User>(con,sQuery, commandType: CommandType.StoredProcedure);
          
        }
    }
}
//}
