using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.DBLinq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BLL.UIHelper
{
    public class tmpinfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string dbtype;

        public string Dbtype
        {
            get { return dbtype; }
            set { dbtype = value; }
        }
        private string filetype;

        public string Filetype
        {
            get { return filetype; }
            set { filetype = value; }
        }
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
    public class TemplateListHelper
    {

        public static void IniDropDownList(DataGridView dgw, string dbtype, string filetype)
        {
            dgw.AutoGenerateColumns = false;
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.Columns[dgw.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MySqlDataContext db = MySqlHelper.DataContext;
            var res = from tmp in db.CfGTemplate
                      select tmp;
            if (dbtype != "")
            {
                res = res.Where(x => x.DbType == dbtype);
            }
            if (filetype != "")
            {
                res = res.Where(x => x.FileType.Contains(filetype));
            }
            List<tmpinfo> ztlist = (from tmp in res
                                    select new tmpinfo() { Id = tmp.ID, Name = tmp.Name, Dbtype = tmp.DbType, Filetype = tmp.FileType, Path = tmp.Path }).ToList<tmpinfo>();

            dgw.DataSource = ztlist;
            dgw.Parent.Height = dgw.Rows.Count * dgw.RowTemplate.Height + dgw.ColumnHeadersHeight + 8;
            dgw.ClearSelection();

        }
    }
}
