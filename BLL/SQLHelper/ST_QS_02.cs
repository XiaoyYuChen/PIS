using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL.Config;
namespace BLL.SQLHelper
{
    //技术生命周期
    public class ST_QS_02
    {
        public static string GetStatSQL(string zid, stcfg cfg, CheckedListBox cklistzhibiao, ComboBox cmbgroupcolumn)
        {
            string strzhibiao = "";
            string columns = "";
            string join = "";
            string groupby = "";
            string wherezt = "st_dt.ztid =" + zid;
            string where = "";
            string tables = "";
            string sql = "select {0},{1} from {2} where {3} {4} {5} group by {6}";
            List<string> tablenames = new List<string>();

            //for (int i = 0; i <= cklistzhibiao.CheckedItems.Count - 1; i++)
            //{
            //    ChartZHIbiAO x = (ChartZHIbiAO)cklistzhibiao.CheckedItems[i];
            //    string tmpzhibiao = string.Format("{0}(distinct {1}.{2} ) as '{3}',", x.FunCType, x.TableName, x.ZHiBIAO, x.ShowName);
            //    tablenames.Add(x.TableName);
            //    strzhibiao += tmpzhibiao;
            //}            
            //strzhibiao = strzhibiao.Trim(',');
            tablenames.Add("st_pa");
            if (cfg.UseCPY == false)
            {
                strzhibiao = " count(distinct st_dt.sid) as '申请量' ,count(distinct st_pa.pa) as '申请人数量' ";


            }
            else
            {
                strzhibiao = " count(distinct st_dt.sid) as '申请量' ,count(distinct st_dt.cpy) as '申请人数量' ";
            }


            ChartColumn group = (ChartColumn)cmbgroupcolumn.SelectedItem;
            columns = string.Format("{0}.{1} as '{2}'", group.TableName, group.ColName, group.ShowName);
            groupby = string.Format("{0}.{1}", group.TableName, group.ColName, group.ShowName);
            tablenames.Add(group.TableName);

            if (cfg.StartYear != 0 && cfg.EndYear != 0)
            {
                where += string.Format(" and {0}.{1} between {2} and {3}", group.TableName, group.ColName, cfg.StartYear, cfg.EndYear);
            }

            tablenames = tablenames.Distinct().ToList<string>();
            tablenames.Remove("st_dt");
            tablenames.Add("st_dt");
            foreach (var tb in tablenames)
            {
                tables += tb + ",";
            }
            tables = tables.Trim(',');

            if (tablenames.Count > 1)
            {
                for (int i = 1; i < tablenames.Count; i++)
                {
                    if (join == "")
                    {
                        join += string.Format("{0}.sid={1}.sid", tablenames[0], tablenames[i]);
                    }
                    else
                    {
                        join += string.Format(" and {0}.sid={1}.sid", tablenames[0], tablenames[i]);
                    }

                }
            }
            if (join == "")
            {
                wherezt = string.Format("st_dt.ztid={0}", zid);
            }
            else
            {
                wherezt = string.Format(" and st_dt.ztid={0}", zid);
            }

            string tmpsql = string.Format(sql, columns, strzhibiao, tables, join, wherezt, where, groupby);

            return tmpsql;
        }
    }
}
