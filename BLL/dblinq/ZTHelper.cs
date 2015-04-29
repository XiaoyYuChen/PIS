using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBA;
using System.Data;
using MySql.Data.MySqlClient;
using DAL;

namespace BLL.DBLinq
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
            var x = from y in MySqlHelper.DataContext.STZTList
                    where y.Name == Name
                    select y;
            if (x.Count() == 0)
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
        public static bool AddZTDB(string Name, string Desc, string type)
        {
            STZTList ztst = new STZTList() { Name = Name, Des = Desc, DbType = type,CreateUserID=1,IsDel=0,CreateTime =DateTime.Now };
            MySqlHelper.DataContext.STZTList.InsertOnSubmit(ztst);
            MySqlHelper.DataContext.SubmitChanges();
            return true;

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
        public static bool DelZTDB(string id)
        {
            MySqlParameter parm = new MySqlParameter("?id", id);
            if (MySqlDbAccess.ExecNoQuery(CommandType.Text, "update st_ztlist set isdel=1 where id=?id", parm).ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
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
            var x = from y in MySqlHelper.DataContext.STZTList
                    where y.ID.ToString() == id
                    select y;
            if (x.Count() == 0)
            {
                return false;
            }
            else
            {
                STZTList zt = x.First();
                zt.Name = Name;
                zt.Des = Desc;
                zt.DbType = type;
                MySqlHelper.DataContext.SubmitChanges();
                return true;

            }
        }
    }
}
