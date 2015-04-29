using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.DBLinq;
using BLL.Model;
using BLL;
using BLL.UIHelper;

namespace PatSI
{
    public partial class frmPtList : Form
    {
        public frmPtList()
        {
            InitializeComponent();
            ZTListHelper.IniZTDropDownList(cmbZtLst);

        }
        public frmPtList(string name, int zid, string type)
        {
            InitializeComponent();
            ZTListHelper.IniZTDropDownList(cmbZtLst, zid, name, type);
        }
        private int nPageCount = 1;
        private int nCuurentPage = 1;
        private int nPageSize = 50;
        private int nPtCount = 0;

        private void frmPtList_Load(object sender, EventArgs e)
        {
            bind();
        }

        public void bind()
        {
            groupBox2.Text = "";

          
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ztinfo zt = (ztinfo)cmbZtLst.SelectedItem;
            int ztid = zt.ID;
            nPtCount = PtDataHelper.getPtDataCount(string.Format("ztid={0}", ztid));
            nPageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(nPtCount) / Convert.ToDouble(nPageSize)));
            if (nPageCount < 1)
            {
                nCuurentPage = 0;

                btnSY.Enabled = false;
                btnPre.Enabled = false;
                btnNext.Enabled = false;
                btnEnd.Enabled = false;

                groupBox2.Text = string.Format("共{0}条数据", nPtCount, nCuurentPage, nPageCount);
                dgvListData.DataSource = null;
                dgvListData.Refresh();
            }
            else
            {
                nCuurentPage=1;
                BingData(nCuurentPage, nPageSize);
            }          
        }

        private void BingData(int nPageidx, int nPageSize)
        {
            if (nPageCount == 0)
                return;

            if (nPageidx > nPageCount)
            {
                nPageidx=nPageCount;
            }
            else if (nPageidx < 1)
            {
                nPageidx = 1;
            }

            btnSY.Enabled = true;
            btnPre.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;

            if (nPageidx == 1)
            {
                btnSY.Enabled = false;
                btnPre.Enabled = false;
            }
            
            if (nPageidx == nPageCount)
            {
                btnNext.Enabled = false;
                btnEnd.Enabled = false;
            }
            ztinfo zt = (ztinfo)cmbZtLst.SelectedItem;
            int ztid = zt.ID;
            dgvListData.DataSource = PtDataHelper.getPtData(string.Format("ztid={0}", ztid), nPageidx, nPageSize);

            nCuurentPage = nPageidx;
            groupBox2.Text = string.Format("共{0}条数据,第{1}页/共{2}页       双击可查看专利的详细信息.", nPtCount, nCuurentPage, nPageCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            By.frmSetShowFiles frm = new By.frmSetShowFiles();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnQuery_Click(sender, e);
            }
        }

        private void dgvListData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvListData.Rows[e.RowIndex].Cells[0];
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

        private void dgvListData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewCell cell = (DataGridViewCell)dgvListData.Rows[e.RowIndex].Cells["ID"];
            MessageBox.Show(cell.Value.ToString());

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSY_Click(object sender, EventArgs e)
        {
            BingData(1, nPageSize);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            BingData(nCuurentPage-1, nPageSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BingData(nCuurentPage +1, nPageSize);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            BingData(nPageCount, nPageSize);
        }
    }
}
