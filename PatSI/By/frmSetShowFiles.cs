using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BLL.Model;

namespace PatSI.By
{
    public partial class frmSetShowFiles : Form
    {
        public frmSetShowFiles()
        {
            InitializeComponent();
        }

        private void frmSetShowFiles_Load(object sender, EventArgs e)
        {
            chkLstBoxFiled.Items.Clear();

            CheckBox ck = null;
            foreach (var item in PtDataHelper.TbShow_base.Values)
            {
                if (!item.ReadOnly)
                {
                    chkLstBoxFiled.Items.Add(item, item.IsShow);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstBoxFiled.Items.Count; i++)
            {
                PtDataHelper.TbShow_base[((TbFiled_Cfg)chkLstBoxFiled.Items[i]).StrFiledName].IsShow = chkLstBoxFiled.GetItemChecked(i);
            }

            MessageBox.Show("设置成功！", this.Text, MessageBoxButtons.OK);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
