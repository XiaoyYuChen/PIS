using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BLL.Import;
using BLL.DBLinq;
using BLL.UIHelper;
using IData;
using System.IO;


namespace PatSI
{
    public partial class DBIN : Form
    {
        private Func<bool> ac;
        private IAsyncResult ar;
        private IDataImport import;
        public DBIN()
        {
            InitializeComponent();
            ZTListHelper.IniZTDropDownList(cmbZTList);
            TemplateListHelper.IniDropDownList(dgwtemplate, "", "");
            //cmbtmp.Enabled = false;
        }
        public DBIN(string name, int zid, string type)
        {
            InitializeComponent();
            ZTListHelper.IniZTDropDownList(cmbZTList, zid, name, type);
            //TemplateListHelper.IniDropDownList(dgwtemplate, "", "");
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            ztinfo zt = (ztinfo)cmbZTList.SelectedItem;
            int ztid = zt.ID;
            string ztname = zt.Name;
            ztname = ztname.Replace(zt.DbType.ToUpper(), "").Trim();
            switch (zt.DbType.ToUpper())
            {
                case "CPRS":
                    import = new CPRSImport(txtFileName.Text.Trim(), ztname, ztid);
                    break;
                case "WPI":
                    import = new WPIImport(txtFileName.Text.Trim(), ztname, ztid);
                    break;
                case "EPODOC":
                    import = new EPODOCImport(txtFileName.Text.Trim(), ztname, ztid);
                    break;
            }
            import.SetMaxProcess += new SetMaxValueEventHander(SetMax);
            import.ShowProcess += new ValueChangedEventHandler(ShowProcess);
            //import.Import();
            ac = new Func<bool>(import.Import);
            ar = ac.BeginInvoke(CallBack, ac);
            //MessageBox.Show("开始导入");                    
            btnCen.Enabled = true;
            this.btnImport.Enabled = false;
        }
        private void CallBack(IAsyncResult ar)
        {
            Func<bool> ac = ar.AsyncState as Func<bool>;
            ac.EndInvoke(ar);
        }
        private void SetMax(object sender, int max)
        {
            //this.toolStripProgressBar1.Maximum = max;
            System.Windows.Forms.MethodInvoker invoker = () =>
            {
                this.tssProcess.Maximum = max;
            };
            if (this.statusStrip1.InvokeRequired)
            {
                this.statusStrip1.Invoke(invoker);
            }
            else
            {
                invoker();
            }
        }
        private void ShowProcess(object sneder, int value, string status)
        {

            System.Windows.Forms.MethodInvoker invoker = () =>
            {
                this.tssProcess.Value = value;
                this.tssMsg.Text = (((float)value) / this.tssProcess.Maximum).ToString("0.00%");
                this.StatusMsg.Text = value + "/" + this.tssProcess.Maximum;
                this.tssStatus.Text = status;
            };
            if (this.statusStrip1.InvokeRequired)
            {
                this.statusStrip1.Invoke(invoker);
            }
            else
            {
                invoker();
            }

            if (value == this.tssProcess.Maximum)
            {
                System.Windows.Forms.MethodInvoker invoker1 = () =>
                {
                    this.btnImport.Enabled = true;
                };
                if (this.btnImport.InvokeRequired)
                {
                    this.btnImport.Invoke(invoker1);
                }
                else
                {
                    invoker1();
                }
                System.Windows.Forms.MethodInvoker invoker3 = () =>
                {
                    this.btnCen.Enabled = false;
                };
                if (this.btnCen.InvokeRequired)
                {
                    this.btnCen.Invoke(invoker3);
                }
                else
                {
                    invoker3();
                }
            }


        }

        private void btnCen_Click(object sender, EventArgs e)
        {

            import.CancelImport();
            import.Dispose();
            tssProcess.Value = 0;
            MessageBox.Show("导入取消");
            this.btnImport.Enabled = true;
            btnCen.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panTemplate.Location = new Point(groupTmplate.Location.X + txtTemplate.Location.X, groupTmplate.Location.Y + this.txtTemplate.Location.Y + this.txtTemplate.Height);
            this.panTemplate.Width = this.txtTemplate.Width;
            this.panTemplate.Visible = true;
            this.panTemplate.Update();
            this.Update();

        }

        private void list_template_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == -1) return;
            this.txtTemplate.Text = this.dgwtemplate.Rows[e.RowIndex].Cells["name"].Value.ToString();
            this.panTemplate.Visible = false;
        }

        private void cmbZTList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ztinfo zt = (ztinfo)cmbZTList.SelectedItem;
            string type = zt.DbType;
            TemplateListHelper.IniDropDownList(dgwtemplate, type, "");

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            string file = txtFileName.Text.Trim();
            if (file == "") return;
            string filetype = Path.GetExtension(this.txtFileName.Text.Trim()).Trim('.');
            ztinfo zt = (ztinfo)cmbZTList.SelectedItem;
            string type = zt.DbType;
            TemplateListHelper.IniDropDownList(dgwtemplate, type, filetype);
        }

        private void txtTemplate_Enter(object sender, EventArgs e)
        {

            string file = txtFileName.Text.Trim();
            if (file == "") return;
            string filetype = Path.GetExtension(this.txtFileName.Text.Trim()).Trim('.');
            ztinfo zt = (ztinfo)cmbZTList.SelectedItem;
            string type = zt.DbType;
            TemplateListHelper.IniDropDownList(dgwtemplate, type, filetype);
            this.panTemplate.Location = new Point(groupTmplate.Location.X + txtTemplate.Location.X, groupTmplate.Location.Y + this.txtTemplate.Location.Y + this.txtTemplate.Height);
            this.panTemplate.Width = this.txtTemplate.Width;
            this.panTemplate.Visible = true;
            this.panTemplate.Update();
            this.Update();
        }

        private void btnFileBrower_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFileName.Text = ofd.FileName;
            }
        }

    }
}
