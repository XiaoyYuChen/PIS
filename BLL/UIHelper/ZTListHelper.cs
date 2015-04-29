using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.DBLinq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BLL.UIHelper
{
    public class ztinfo
    {
        public int ID;
        public string Name;
        public string DbType;
        public string DisplayName;

        public override string ToString()
        {
            return DisplayName;
        }
    }
    public class ZTListHelper
    {

        public static void IniZTDropDownList(ComboBox cb)
        {
            cb.Items.Clear();
            MySqlDataContext db = MySqlHelper.DataContext;
            List<ztinfo> ztlist =(from tmp in db.STZTList
                         where tmp.IsDel.Value == 0
                         select new ztinfo() { ID = tmp.ID, Name = tmp.Name, DbType = tmp.DbType }).ToList<ztinfo>();
            //select new { Name = tmp.Name ,type= tmp.DbType , Id = tmp.ID };


            foreach (var zt in ztlist)
            {
                zt.DisplayName = string.Format("{0}{1}", getcharlen(zt.Name), zt.DbType);
            }
            cb.DataSource = ztlist;
            cb.SelectedIndex = 0;

        }
        public static void IniZTDropDownList(ComboBox cb, int id, string name, string type)
        {
            cb.Items.Clear();
            List<ztinfo> ztlist = new List<ztinfo>();
            ztlist.Add(new ztinfo() { ID = id, Name = name, DbType = type });

            foreach (var zt in ztlist)
            {
                zt.DisplayName = string.Format("{0}{1}", getcharlen(zt.Name), zt.DbType);
            }
            cb.DataSource = ztlist;
            cb.SelectedIndex = 0;

        }
        public static string getcharlen(string str)
        {
            Regex reg = new Regex("[\u4e00-\u9fa5]");
            MatchCollection mh = reg.Matches(str);
            int len = mh.Count;
            return str.PadRight((80 - len), ' ');
        }
    }
}
