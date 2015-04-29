using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace BLL.UIHelper
{
    public class STUIHelper
    {

        public static void initLeftTree(TreeView tw, string dbtype)
        {
            MySqlDataContext db = new MySqlDataContext();
            tw.Nodes.Clear();
            switch (dbtype.ToUpper())
            {
                case "CPRS":
                    var group = from g in db.ChartGroup
                                where g.CN == 1
                                select g;
                    foreach (ChartGroup x in group)
                    {
                        var chridren = from y in MySqlHelper.DataContext.ChartItems
                                       where y.ChartGroup == x.ChartGroup1 && y.CN == 1
                                       select y;
                        if (chridren.Count() > 0)
                        {
                            TreeNode node = new TreeNode(x.ChartGroup1);
                            foreach (var tmp in chridren)
                            {
                                TreeNode tmpnode = new TreeNode(tmp.ItemName);
                                tmpnode.ToolTipText = tmp.ItemDesC;
                                node.Nodes.Add(tmpnode);
                            }
                            tw.Nodes.Add(node);
                        }

                    }
                    break;
                case "WPI":
                    var group1 = from g in db.ChartGroup
                                 where g.Wpi == 1
                                 select g;
                    foreach (ChartGroup x in group1)
                    {
                        var chridren = from y in MySqlHelper.DataContext.ChartItems
                                       where y.ChartGroup == x.ChartGroup1 && y.Wpi == 1
                                       select y;
                        if (chridren.Count() > 0)
                        {
                            TreeNode node = new TreeNode(x.ChartGroup1);
                            foreach (var tmp in chridren)
                            {
                                TreeNode tmpnode = new TreeNode(tmp.ItemName);
                                tmpnode.ToolTipText = tmp.ItemDesC;
                                node.Nodes.Add(tmpnode);
                            }
                            tw.Nodes.Add(node);
                        }

                    }
                    break;
                case "EPODOC":
                    var group2 = from g in db.ChartGroup
                                 where g.EPodOC == 1
                                 select g;
                    foreach (ChartGroup x in group2)
                    {
                        var chridren = from y in MySqlHelper.DataContext.ChartItems
                                       where y.ChartGroup == x.ChartGroup1 && y.EPodOC == 1
                                       select y;
                        if (chridren.Count() > 0)
                        {
                            TreeNode node = new TreeNode(x.ChartGroup1);
                            foreach (var tmp in chridren)
                            {
                                TreeNode tmpnode = new TreeNode(tmp.ItemName);
                                tmpnode.ToolTipText = tmp.ItemDesC;
                                node.Nodes.Add(tmpnode);
                            }
                            tw.Nodes.Add(node);
                        }

                    }
                    break;
            }

            tw.ExpandAll();
        }
        /// <summary>
        /// 根据统计分析类型 确定 图标的类型
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="dbtype"></param>
        /// <param name="itemname"></param>
        public static void initCharColumn(ComboBox cmb, string dbtype, string itemname)
        {
            using (MySqlDataContext db = new MySqlDataContext())
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.Items.Clear();
                List<ChartColumn> res = null;
                switch (dbtype.ToUpper())
                {
                    case "CPRS":
                        res = (from tmp in db.ChartColumn
                               where tmp.CN == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartColumn>();
                        break;
                    case "WPI":
                        res = (from tmp in db.ChartColumn
                               where tmp.Wpi == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartColumn>();
                        break;
                    case "EPODOC":
                        res = (from tmp in db.ChartColumn
                               where tmp.EPodOC == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartColumn>();
                        break;
                }

                foreach (var tmp in res)
                {
                    cmb.Items.Add(tmp);
                }
                cmb.DisplayMember = "ShowName";
                if (cmb.Items.Count > 0)
                {
                    cmb.SelectedIndex = 0;
                }
            }

        }
        /// <summary>
        /// 初始化统计字段类型
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="dbtyp"></param>
        /// <param name="itemname"></param>
        public static void initChartType(ComboBox cmb, string itemname)
        {
            using (MySqlDataContext db = new MySqlDataContext())
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.Items.Clear();
                var res = from tmp in db.ChartType
                          where tmp.ItemName == itemname
                          select tmp;
                foreach (var tmp in res)
                {
                    cmb.Items.Add(tmp);
                }
                cmb.DisplayMember = "ShowName";
                cmb.ValueMember = "ItemName";
                if (cmb.Items.Count > 0)
                {
                    cmb.SelectedIndex = 0;
                }
            }
        }

        public static void initChartZhiBiao(CheckedListBox cklst, string dbtype, string itemname)
        {
            using (MySqlDataContext db = new MySqlDataContext())
            {
                cklst.Items.Clear();
                List<ChartZHIbiAO> res = null;
                switch (dbtype.ToUpper())
                {
                    case "CPRS":
                        res = (from tmp in db.ChartZHIbiAO
                               where tmp.CN == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartZHIbiAO>();
                        break;
                    case "WPI":
                        res = (from tmp in db.ChartZHIbiAO
                               where tmp.Wpi == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartZHIbiAO>();
                        break;
                    case "EPODOC":
                        res = (from tmp in db.ChartZHIbiAO
                               where tmp.EPodOC == 1 && tmp.ItemName == itemname
                               select tmp).ToList<ChartZHIbiAO>();
                        break;
                }
                foreach (var tmp in res)
                {
                    cklst.Items.Add(tmp);
                }
                cklst.DisplayMember = "ShowName";
                if (cklst.Items.Count > 0)
                {
                    cklst.SetItemChecked(0, true);
                    cklst.SelectedIndex = 0;

                }
            }
        }
        
    }
}
