using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBA;
using System.Data;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class ZTHelper
    {
        /// <summary>
        /// 判断专题库是否存在
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool ExistZTDB(string Name)
        {
            MySqlParameter parm = new MySqlParameter("?name", Name);
            if (MySqlDbAccess.ExecuteScalar(CommandType.Text, "select count(*) from st_ztlist where name=?name and isdel=0", parm).ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// 添加专题库
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Desc"></param>
        /// <returns></returns>
        public static bool AddZTDB(string Name, string Desc,string type)
        {
            MySqlParameter[] parms = new MySqlParameter[]
            {
                new MySqlParameter("?name",Name),
                new MySqlParameter("?des",Desc),
                new MySqlParameter("?dbtype",type),
                new MySqlParameter("?createuserid",UserHelper.user.UserId),
                new MySqlParameter("?createtime",DateTime.Now.ToString())
            };
            if (MySqlDbAccess.ExecNoQuery(CommandType.Text, "insert into st_ztlist (name,des,dbtype,createuserid,createtime,isdel) values (?name,?des,?dbtype,?createuserid,?createtime,0)", parms) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 得到专题库列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetZTList()
        {
            return MySqlDbAccess.GetDataTable(CommandType.Text, "select * from st_ztlist where isdel =0");
        }
        /// <summary>
        /// 删除专题库
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DelZTDB(string ids)
        {            
            if (MySqlDbAccess.ExecNoQuery(CommandType.Text, String.Format("update st_ztlist set isdel=1 where id in({0})", ids)).ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改专题库
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Name"></param>
        /// <param name="Desc"></param>
        /// <returns></returns>
        public static bool EditZTDB(string id, string Name, string Desc,string type)
        {
            MySqlParameter[] parms = new MySqlParameter[]
            {
                new MySqlParameter("?name",Name),
                new MySqlParameter("?des",Desc),
                new MySqlParameter("?id",id)
            };
            if (MySqlDbAccess.ExecNoQuery(CommandType.Text, "update st_ztlist set name = ?name,des=?des where id=?id", parms) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
