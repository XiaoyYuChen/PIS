using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatSI
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }



        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }



        private void 专题库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZTListNew frmnewzt = new ZTListNew();
            frmnewzt.MdiParent = this;
            frmnewzt.Show();
        }

        private void 添加数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBIN dbin = new DBIN();
            dbin.ShowDialog();
        }

        private void 管理GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Template tmp = new Template();
            tmp.Show();
        }

        private void 人工标引RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPtList frm = new frmPtList();
            frm.Show();
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            ZTListNew ztlist = new ZTListNew();
            ztlist.MdiParent = this;
            ztlist.Show();
            //ztlist.Focus();
            ztlist.Select();
        }

        private void 选择专题SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZTListNew frmnewzt = new ZTListNew();
            frmnewzt.MdiParent = this;
            frmnewzt.Show();
        }
    }
}
