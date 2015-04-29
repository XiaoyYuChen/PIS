using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PatSI
{
    public partial class ZTListNew : Form
    {
        private int rowindex = 0;
        public ZTListNew()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            bind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewZT frmnewzt = new NewZT();
            if (frmnewzt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bind();
            }
        }
        public void bind()
        {
            DataTable dt = ZTHelper.GetZTList();
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            rowindex = e.RowIndex;

            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
            Boolean flag = Convert.ToBoolean(cell.Value);
            if (flag == true)
            {
                cell.Value = false;
            }
            else
            {
                cell.Value = true;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //cell.ContextMenuStrip = contextMenuStrip1;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(string.Format("请选择要编辑的数据"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow datarow = dataGridView1.SelectedRows[0];
            string name = (datarow.Cells["name"].Value == null ? "" : datarow.Cells["name"].Value.ToString());
            string des = (datarow.Cells["des"].Value == null ? "" : datarow.Cells["des"].Value.ToString());
            string type = (datarow.Cells["type"].Value == null ? "CPRS" : datarow.Cells["type"].Value.ToString());
            NewZT frm = new NewZT(datarow.Cells["id"].Value.ToString(), name, des, type);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bind();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            List<int> listids = new List<int>();
            string ids = ",";
            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)x.Cells[0];
                Boolean flag = Convert.ToBoolean(cell.Value);
                if (flag)
                {
                    ids += x.Cells["id"].Value.ToString() + ",";
                    listids.Add(Convert.ToInt32(x.Cells["id"].Value.ToString()));
                }
            }
            if (listids.Count <= 0)
            {
                MessageBox.Show(string.Format("请选择要删除的数据"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(string.Format("您将要删除复选框选中的 【{0}】 条专题库", listids.Count), "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                ids = ids.Trim(',');

                if (ZTHelper.DelZTDB(ids))
                {
                    bind();
                }

            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow datarow = dataGridView1.SelectedRows[0];
            string name = (datarow.Cells["name"].Value == null ? "" : datarow.Cells["name"].Value.ToString());
            string des = (datarow.Cells["des"].Value == null ? "" : datarow.Cells["des"].Value.ToString());
            string type = (datarow.Cells["type"].Value == null ? "CPRS" : datarow.Cells["type"].Value.ToString());
            if (MessageBox.Show("您确定要删除专题库 【" + name + "】 吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (ZTHelper.DelZTDB(datarow.Cells["id"].Value.ToString()))
                {
                    bind();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(string.Format("请选择要导入的数据库"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow datarow = dataGridView1.SelectedRows[0];
            string name = (datarow.Cells["name"].Value == null ? "" : datarow.Cells["name"].Value.ToString());
            string des = (datarow.Cells["des"].Value == null ? "" : datarow.Cells["des"].Value.ToString());
            string type = (datarow.Cells["type"].Value == null ? "CPRS" : datarow.Cells["type"].Value.ToString());
            int id = Convert.ToInt32(datarow.Cells["id"].Value.ToString());
            DBIN frmdbin = new DBIN(name, id, type);
            frmdbin.MdiParent = this.MdiParent;
            frmdbin.Show();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(string.Format("请选择要标引的数据库"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow datarow = dataGridView1.SelectedRows[0];
            string name = (datarow.Cells["name"].Value == null ? "" : datarow.Cells["name"].Value.ToString());
            string des = (datarow.Cells["des"].Value == null ? "" : datarow.Cells["des"].Value.ToString());
            string type = (datarow.Cells["type"].Value == null ? "CPRS" : datarow.Cells["type"].Value.ToString());
            int id = Convert.ToInt32(datarow.Cells["id"].Value.ToString());
            frmPtList frmdbin = new frmPtList(name, id, type);
            frmdbin.MdiParent = this.MdiParent;
            frmdbin.Show();

        }

        private void btnST_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(string.Format("请选择要统计分析的数据库"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow datarow = dataGridView1.SelectedRows[0];
            string name = (datarow.Cells["name"].Value == null ? "" : datarow.Cells["name"].Value.ToString());
            string des = (datarow.Cells["des"].Value == null ? "" : datarow.Cells["des"].Value.ToString());
            string type = (datarow.Cells["type"].Value == null ? "CPRS" : datarow.Cells["type"].Value.ToString());
            int id = Convert.ToInt32(datarow.Cells["id"].Value.ToString());
            frmstat st = new frmstat(name,id,type);
            //frmstat st = new frmstat();
            st.MdiParent = this.MdiParent;
            st.Show();

        }






    }
}
