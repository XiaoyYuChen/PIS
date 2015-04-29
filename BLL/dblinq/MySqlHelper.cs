using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class MySqlHelper
    {

        public static MySqlDataContext DataContext = new MySqlDataContext();


        public static void init()
        {
            
        }
    }
}
