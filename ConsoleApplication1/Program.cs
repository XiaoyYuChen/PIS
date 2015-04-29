using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DBA.MySqlDbAccess.ExecNoQuery(System.Data.CommandType.Text, "insert into xy (name) values ('陈晓雨')");

            DataTable dt = DBA.MySqlDbAccess.GetDataTable(System.Data.CommandType.Text, "select * from xy");
            foreach (DataRow x in dt.Rows)
            {
                Console.WriteLine(x[1].ToString());
            }
            Console.Read();
        }

    }
}
