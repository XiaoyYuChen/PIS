using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class MySqlDataContext : ZTST
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlServerStr"].ConnectionString;
        public MySqlDataContext(MySqlConnection conn)
            : base(conn)
        {

        }
        public MySqlDataContext()
            : base(new MySqlConnection(constr))
        {
        }

    }
}
